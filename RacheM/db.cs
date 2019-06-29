using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacheM
{
    public class db
    {
        private static string cnString = "Data Source = " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "myData");


        private static Dictionary<int, PrizeItem> prizes = null;
        public static Dictionary<string, PrizeItem> prizesByName = new Dictionary<string, PrizeItem>();

        public static void deletePrizeForUsers(IEnumerable<User> users, int prizeId)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                var sql = String.Format("DELETE FROM cross WHERE prizeId = {0} AND playerId IN ({1})", prizeId
                    , String.Join(",", users.Select(u => u.Id)));
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void addPrizeToPlayer(User user, PrizeItem prize)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO players (name) VALUES ('@username')", cn);
                cmd.Parameters.Add("@username", DbType.String).Value = user.Name.ToLower();
                if(user.Id == 0)
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select last_insert_rowid()";
                    user.Id = (int)(long)cmd.ExecuteScalar();
                }
                cmd.CommandText = $"INSERT INTO cross (playerId, prizeId) VALUES ({user.Id}, {prize.Id})";
                cmd.ExecuteNonQuery();
            }
        }

        public static void deletePrizeFromPlayer(User user, PrizeItem prize)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM cross WHERE id IN (SELECT id FROM cross WHERE playerId = {user.Id} AND prizeId = {prize.Id} LIMIT 1)", cn);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<String> getUserList()
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT name FROM players", cn);

                List<String> result = new List<String>();

                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        result.Add(sdr["name"].ToString());
                    }
                    return result;
                }

            }
        }

        public static User getUserByField(object value, string fieldName = "name")
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand(string.Format("SELECT * FROM players WHERE {0}=@value", fieldName), cn);
                if (fieldName != "name")
                {
                    cmd.Parameters.Add("@value", DbType.Int32).Value = (int)value;
                }
                else
                {
                    cmd.Parameters.Add("@value", DbType.String).Value = value.ToString().ToLower();
                }

                User result = null;
                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        result = new User
                        {
                            Id = sdr.GetInt32(0),
                            Name = sdr["name"].ToString()
                        };
                    }
                    else
                    {
                        return null;
                    }
                }

                cmd.CommandText = String.Format("SELECT prizeId FROM cross WHERE playerId={0}", result.Id);
                using (SQLiteDataReader prizedr = cmd.ExecuteReader())
                {
                    while (prizedr.Read())
                    {
                        result.prizes.Add(db.getPrizes()[prizedr.GetInt32(0)]);
                    }
                }

                return result;
            }
        }

        public static Dictionary<int, PrizeItem> getPrizes()
        {
            if (db.prizes != null)
            {
                return db.prizes;
            }
            Dictionary<int, PrizeItem> prizes = new Dictionary<int, PrizeItem>();

            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM prizes", cn);
                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        PrizeItem newPrize = new PrizeItem
                        {
                            Id = sdr.GetInt32(0),
                            IsBad = sdr.GetInt32(4),
                            Type = sdr.GetInt32(2),
                            Name = sdr["name"].ToString(),
                            Unique = sdr.GetBoolean(sdr.GetOrdinal("isUnique"))
                        };
                        prizes.Add(sdr.GetInt32(0), newPrize);
                        prizesByName.Add(sdr["name"].ToString(), newPrize);
                        byte[] bytBLOB = new byte[sdr.GetBytes(3, 0, null, 0, int.MaxValue) - 1];
                        sdr.GetBytes(3, 0, bytBLOB, 0, bytBLOB.Length);

                        MemoryStream stmBLOB = new MemoryStream(bytBLOB);
                        prizes[sdr.GetInt32(0)].Image = Image.FromStream(stmBLOB);
                    }
                }
            }
            db.prizes = prizes;
            return prizes;
        }

        public static List<User> getPrizePlayers(int prId)
        {
            List<User> result = new List<User>();

            using(SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM cross INNER JOIN players ON cross.playerId = players.id WHERE prizeId = {prId}", cn);

                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        result.Add(getUserByField(sdr["name"].ToString()));
                    }
                }
            }

            return result;
        }

        public static void clearRoom(int room)
        {
            string roomName = room == 0 ? "golden_room" : "platinum_room";

            using(SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();

                SQLiteCommand cmd = new SQLiteCommand(string.Format("DELETE FROM {0}", roomName), cn);
                cmd.ExecuteNonQuery();
            }
        }

        public static Dictionary<int, int> getRoom(int room)
        {
            string roomName = room == 0 ? "golden_room" : "platinum_room";
            Dictionary<int, int> result = new Dictionary<int, int>();

            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();

                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {roomName}", cn);

                using(SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        result.Add(sdr.GetInt32(0), sdr.GetInt32(1));
                    }
                }
            }

            return result;
        }

       public static void saveRoom(int room, Dictionary<int, int> positions)
        {
            string roomName = room == 0 ? "golden_room" : "platinum_room";
            
            using(SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                SQLiteCommand cmd = new SQLiteCommand("", cn);

                cn.Open();
                foreach(int i in positions.Keys)
                {
                    cmd.CommandText += $"INSERT INTO {roomName} (id, playerId) VALUES ({i}, '{positions[i]}');";
                    
                }
                cmd.ExecuteNonQuery();
            }
        }

       public static Image getCard(int cardId)
        {
            Image result;
            using(SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT image FROM cards WHERE id={cardId}", cn);

                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        byte[] bytBLOB = new byte[sdr.GetBytes(0, 0, null, 0, int.MaxValue) - 1];
                        sdr.GetBytes(0, 0, bytBLOB, 0, bytBLOB.Length);


                        MemoryStream stmBLOB = new MemoryStream(bytBLOB);
                        result = Image.FromStream(stmBLOB);

                        return result;
                    }
                }
            }

            return null;
        }

        public static Settings getSettings()
        {
            Settings result = new Settings();

            result.twitchSettings = new TwitchSettings();

            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM settings WHERE id=1", cn);

                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        result.twitchSettings.password = sdr["password"].ToString();
                        result.twitchSettings.channelName = sdr["channelName"].ToString();
                        result.twitchSettings.botUsername = sdr["botUsername"].ToString();
                        result.twitchSettings.botToken = sdr["botToken"].ToString();
                        result.twitchSettings.clientId = sdr["clientId"].ToString();
                        result.fpsLimit = sdr.GetInt32(sdr.GetOrdinal("fps_limit"));
                    }

                    return result;
                }
            }
        }

        public static void setSettings(Settings settings)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM settings WHERE id=1", cn);

                cmd.ExecuteNonQuery();

                cmd = new SQLiteCommand($"INSERT INTO settings (id, password, channelName, botUsername, botToken, clientId, fps_limit) VALUES (1, '{settings.twitchSettings.password}', '{settings.twitchSettings.channelName}', '{settings.twitchSettings.botUsername}', '{settings.twitchSettings.botToken}', '{settings.twitchSettings.clientId}', {settings.fpsLimit});", cn);

                cmd.ExecuteNonQuery();
            }
        }

        public static float getPlayerBalance(object field, string fieldName = "name")
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand(string.Format("SELECT * FROM players WHERE {0}=@value", fieldName), cn);
                if (fieldName != "name")
                {
                    cmd.Parameters.Add("@value", DbType.Int32).Value = (int)field;
                }
                else
                {
                    cmd.Parameters.Add("@value", DbType.String).Value = field.ToString().ToLower();
                }

                float result = -1;
                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        result = sdr.GetFloat(sdr.GetOrdinal("balance"));
                    }
                    else
                    {
                        return 0;
                    }
                }

                return result;
            }
        }

        public static void addPlayerBalance(string field, float addBalance = 0)
        {
            bool isExist = false;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM players WHERE name=@value", cn);

                cmd.Parameters.Add("@value", DbType.String).Value = field.ToString().ToLower();

                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        isExist = true;
                    }
                }

                if (isExist)
                {
                    SQLiteCommand cmd1 = new SQLiteCommand(string.Format("UPDATE players SET balance = balance + {0} WHERE name=@value", addBalance.ToString(nfi)), cn);

                    cmd1.Parameters.Add("@value", DbType.String).Value = field.ToLower();

                    cmd1.ExecuteNonQuery();
                } else
                {
                    SQLiteCommand cmd1 = new SQLiteCommand(string.Format("INSERT INTO players (name, balance) VALUES (@name, {0})", addBalance.ToString(nfi)), cn);

                    cmd1.Parameters.Add("@name", DbType.String).Value = field.ToLower();

                    cmd1.ExecuteNonQuery();
                }
            }
        }
    }
}

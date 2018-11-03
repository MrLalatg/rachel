using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacheM
{
    public class db
    {
        private static string cnString = "Data Source = myData";
        private static Dictionary<int, PrizeItem> prizes = null;

        public static int saveUser(User user)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand(string.Format("INSERT INTO players (name) VALUES ('{0}')", user.Name.ToLower()), cn);
                if (user.Id == 0)
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select last_insert_rowid()";
                    user.Id = (int) (long) cmd.ExecuteScalar();
                }
                else
                {
                    cmd.CommandText = string.Format("DELETE FROM cross WHERE playerId='{0}'", user.Id);
                    cmd.ExecuteNonQuery();
                }

                foreach (PrizeItem i in user.prizes)
                {
                    cmd.CommandText = string.Format("INSERT INTO cross (playerId, prizeId) VALUES ({0}, {1})", user.Id, i.Id);
                    cmd.ExecuteNonQuery();
                }

            }
            return user.Id;
        }

        public static User getUserByName(string name)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cnString))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand(string.Format("SELECT * FROM players WHERE name='{0}'", name.ToLower()), cn);
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
            using (SQLiteConnection cn = new SQLiteConnection("Data Source = myData"))
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM prizes", cn);
                using (SQLiteDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        prizes.Add(sdr.GetInt32(0),
                            new PrizeItem
                            {
                                Id = sdr.GetInt32(0),
                                IsBad = sdr.GetInt32(4),
                                Type = sdr.GetInt32(2),
                                Name = sdr["name"].ToString(),
                            }
                        );
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
    }
}

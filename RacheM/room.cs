using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RacheM
{
    public partial class room : UserControl
    {
        private string currentNick;
        private int currentRoom;
        private Dictionary<int, int> forWrite = new Dictionary<int, int>();
        private int prizeId = 27;
        public room()
        {
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            bool nullOrE = false;
            if (string.IsNullOrEmpty(currentNick))
            {
                nullOrE = true;
            }
            if (!nullOrE && db.getUserByField(currentNick) == null)
            {
                MessageBox.Show("Такого пользователья не существует", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            ((Button)sender).Text = string.IsNullOrEmpty(currentNick) ? "" : currentNick;
            db.clearRoom(currentRoom);
            forWrite = this.Controls
                .OfType<Button>()
                .Where(p => p.Name.Contains("btn") && !string.IsNullOrEmpty(p.Text))
                .Select(btn => new KeyValuePair<int, int>(int.Parse(btn.Name.Replace("btn", "")), db.getUserByField(btn.Text).Id))
                .ToDictionary(r => r.Key, r => r.Value);
            db.saveRoom(currentRoom, forWrite);
        }

        private void nick_TextChanged(object sender, EventArgs e)
        {
            currentNick = nick.Text;
        }

        public void init(int roomIn)
        {
            currentRoom = roomIn;
            if (roomIn == 1)
            {
                prizeId = 1;
                Dictionary<int, int> newRoom = db.getRoom(currentRoom);
                this.Controls.OfType<Button>().Where(p => p.Name.Contains("btn")).ToList().ForEach(r =>
                    {
                        r.Text = newRoom.ContainsKey(int.Parse(r.Name.Replace("btn", "")))
                            ? db.getUserByField(newRoom[int.Parse(r.Name.Replace("btn", ""))], "id").Name
                            : "";
                    });
            } else
            {
                prizeId = 27;
                List<User> newRoom = db.getPrizePlayers(prizeId).Take(10).ToList();

                nick.Visible = false;

                if (newRoom.Count < 10)
                {
                    while (newRoom.Count != 10)
                    {
                        newRoom.Add(null);
                    }
                }

                this.Controls.OfType<Button>().Where(p => p.Name.Contains("btn")).ToList().ForEach(r =>
                    {
                        r.Text = newRoom[(int.Parse(r.Name.Replace("btn", "")))-1] != null
                            ? newRoom[(int.Parse(r.Name.Replace("btn", "")))-1].Name
                            : "";
                    });
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            List<Button> btns = this.Controls
                                    .OfType<Button>()
                                    .Where(p => p.Name.Contains("btn"))
                                    .ToList();
            btns.Select(p => p.FlatAppearance.BorderSize = 0);
            ((mainForm)Parent).onHome(this);
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Button winBtn = new Button();
            User curUsr = new User();
            int tempRnd = rnd.Next(0, 10);
            int lastRnd = tempRnd;
            List<Button> btns = this.Controls
                                    .OfType<Button>()
                                    .Where(p => p.Name.Contains("btn"))
                                    .ToList();
            for (int i = 0; i < 20; i++)
            {
                while(tempRnd == lastRnd)
                {
                    tempRnd = rnd.Next(0, 10);
                }
                btns[tempRnd].FlatAppearance.BorderColor = Color.Yellow;
                btns[tempRnd].FlatAppearance.BorderSize = 3;
                winBtn = btns[tempRnd];
                await Task.Delay(500);
                btns[tempRnd].FlatAppearance.BorderSize = 0;
                lastRnd = tempRnd;
            }

            winBtn.FlatAppearance.BorderColor = Color.Green;
            winBtn.FlatAppearance.BorderSize = 5;

            ((mainForm)Parent).roomres1.setNick(winBtn.Text);
            await Task.Delay(500);
            winBtn.FlatAppearance.BorderSize = 0;
            ((mainForm)Parent).roomres1.Visible = true;
            this.Hide();

            foreach (Button i in btns)
            {
                curUsr = db.getUserByField(i.Text);
                curUsr.prizes.RemoveAt(curUsr.prizes.FindLastIndex(p => p.Id == prizeId));
                db.saveUser(curUsr);
            }
        }
    }
}

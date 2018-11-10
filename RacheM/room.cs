using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacheM
{
    public partial class room : UserControl
    {
        private string currentNick;
        private int currentRoom;
        private List<Button> btns = new List<Button>();
        private Dictionary<int, int> forWrite = new Dictionary<int, int>();
        public room()
        {
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            if (db.getUserByField(currentNick) == null)
            {
                MessageBox.Show("Ошибка", "Пользователя не существует", MessageBoxButtons.OK);
                return;
            }
            ((Button)sender).Text = currentNick;
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
            Dictionary<int, int> newRoom = db.getRoom(currentRoom);
            this.Controls.OfType<Button>().Where(p => p.Name.Contains("btn")).ToList().ForEach(r =>
                {
                    r.Text = newRoom.ContainsKey(int.Parse(r.Name.Replace("btn", "")))
                        ? db.getUserByField(newRoom[int.Parse(r.Name.Replace("btn", ""))], "id").Name
                        : "";
                });
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }
    }
}

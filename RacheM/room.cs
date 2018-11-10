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
        private Dictionary<int, string> forWrite = new Dictionary<int, string>();
        public room()
        {
            InitializeComponent();
            btns = new List<Button>{btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10};
        }

        private void onClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = currentNick;
            db.clearRoom(currentRoom);
            foreach(Button i in btns)
            {
                forWrite.Add(int.Parse(i.Tag.ToString()), i.Text);
            }
            db.saveRoom(currentRoom, forWrite);
        }

        private void nick_TextChanged(object sender, EventArgs e)
        {
            currentNick = nick.Text;
        }

        private void read()
        {

        }

        public void init(int roomIn)
        {
            currentRoom = roomIn;
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }
    }
}

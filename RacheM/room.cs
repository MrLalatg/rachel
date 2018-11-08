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
        public room()
        {
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = currentNick;
        }

        private void nick_TextChanged(object sender, EventArgs e)
        {
            currentNick = nick.Text;
        }

        private void read()
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }
    }
}

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
    public partial class roomres : UserControl
    {
        public roomres()
        {
            InitializeComponent();
        }

        public void setNick(string nick)
        {
            nickBox.ForeColor = Color.Firebrick;
            nickBox.Text = nick;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }
    }
}

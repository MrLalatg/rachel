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
    public partial class informPanel : UserControl
    {
        public informPanel()
        {
            InitializeComponent();
        }

        private void mrlalatgBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/lalatg");
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }

        private void rachelBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id33343141");
        }
    }
}

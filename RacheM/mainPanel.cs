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
    public partial class mainPanel : UserControl
    {
        public mainPanel()
        {
            InitializeComponent();
        }

        private void commonCase_Click(object sender, EventArgs e)
        {
            Visible = false;
            ((mainForm)Parent).commonPanel1.Visible = true;
        }

        private void eliteBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            ((mainForm)Parent).eliteCase1.createPrize();
            ((mainForm)Parent).eliteCase1.Visible = true;
        }

        private void nickName_TextChanged(object sender, EventArgs e)
        {
            ((mainForm)Parent).currentNick = nickName.Text;
        }
    }
}

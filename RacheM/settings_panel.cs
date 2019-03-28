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
    public partial class settings_panel : UserControl
    {
        public settings_panel()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.setSettings(this.donPassword.Text, this.channelName.Text, this.botUsername.Text, this.botToken.Text, this.clientId.Text);
        }
    }
}

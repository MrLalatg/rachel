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
            mainForm.settings.twitchSettings.botToken = this.botToken.Text;
            mainForm.settings.twitchSettings.botUsername = this.botUsername.Text;
            mainForm.settings.twitchSettings.password = this.donPassword.Text;
            mainForm.settings.twitchSettings.clientId = this.clientId.Text;
            mainForm.settings.twitchSettings.channelName = this.channelName.Text;
            mainForm.settings.fpsLimit = this.fps_value.SelectedItem.ToString() == "None" ? 0 : Convert.ToInt32(this.fps_value.SelectedItem);
            db.setSettings(mainForm.settings);
        }
    }
}

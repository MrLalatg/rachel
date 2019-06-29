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
    public partial class mainPanel : UserControl
    {
        public mainPanel()
        {
            InitializeComponent();
        }

        private void commonCase_Click(object sender, EventArgs e)
        {
            if (((mainForm)Parent).currentNick == null || ((mainForm)Parent).currentNick == "")
            {
                error.Visible = true;
            } else
            {
                error.Visible = false;
                Visible = false;
                ((mainForm)Parent).commonPanel1.Visible = true;
            }
        }

        private void nickName_TextChanged(object sender, EventArgs e)
        {
            ((mainForm)Parent).currentNick = nickName.Text;    
            error.Visible = false;
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            if (((mainForm)Parent).currentNick == null || ((mainForm)Parent).currentNick == "")
            {
                error.Visible = true;
            } else {
                error.Visible = false;
                User currentPlayer = db.getUserByField(((mainForm)Parent).currentNick);
                if (currentPlayer == null)
                {
                    currentPlayer = new User { Name = ((mainForm)Parent).currentNick };
                }
                ((mainForm)Parent).inventoryPanel1.setUser(currentPlayer);
                ((mainForm)Parent).inventoryPanel1.Visible = !((mainForm)Parent).inventoryPanel1.Visible;
                commonCase.Enabled = false;
                nickName.Enabled = false;
            }
        }

        private void showPrizesBtn_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).prizesPanel1.Visible = true;
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).informPanel1.Visible = true;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).settings_panel1.Visible = true;
            mainForm.settings = db.getSettings();
            string curFps = mainForm.settings.fpsLimit == 0 ? "None" : mainForm.settings.fpsLimit.ToString();
            ((mainForm)Parent).settings_panel1.donPassword.Text = mainForm.settings.twitchSettings.password;
            ((mainForm)Parent).settings_panel1.channelName.Text = mainForm.settings.twitchSettings.channelName;
            ((mainForm)Parent).settings_panel1.botUsername.Text = mainForm.settings.twitchSettings.botUsername;
            ((mainForm)Parent).settings_panel1.botToken.Text = mainForm.settings.twitchSettings.botToken;
            ((mainForm)Parent).settings_panel1.clientId.Text = mainForm.settings.twitchSettings.clientId;
            ((mainForm)Parent).settings_panel1.fps_value.SelectedIndex = ((mainForm)Parent).settings_panel1.fps_value.FindStringExact(curFps);
        }

        private void nickName_Enter(object sender, EventArgs e)
        {
            nickName.AutoCompleteList = ((mainForm)Parent).usersList;
            nickName.MinTypedCharacters = 1;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            mainForm.logger.Show();
        }
    }
}

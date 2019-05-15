using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RacheM
{

    public partial class mainForm : Form
    {
        public string backAdress;
        public string currentNick = null;
        public TwitchSettings settings;
        DonationListener dl;
        TwitchBot bot;
        overlay ol = new overlay();

        public System.Windows.Forms.PictureBox[,] eliteCards;
        public mainForm()
        {
            InitializeComponent();
            ol.Show();
            settings = db.getSettings();
            if (settings.password != "")
            {
                initializeDonation();
            } else
            {
                MessageBox.Show(
                    "Для корректной работы с DonationAlerts нужен токен, вы можете ввести его в настройках, затем ПЕРЕЗАПУСТИТЕ ПРОГРАММУ", 
                    "Отсутствует токен DonationAlerts",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            bot = new TwitchBot(this.settings);
            bot.connect();
        }

        public delegate void InvokeDelegate(JObject donation);

        public void InvokeMethod( JObject donation)
        {
            string username = donation["username"].ToString();
            User toRide = db.getUserByField(username);
            if(toRide == null)
            {
                toRide = new User() { Name = username };
                db.saveUser(toRide);
            }
            ol.ride(toRide);
        }


        public void initializeDonation()
        {
            ol.paintGreen();
            dl = new DonationListener(settings.password);
            dl.OnDonation = donation =>
            {
                this.BeginInvoke(new InvokeDelegate(InvokeMethod), donation);

            };

            Task t = new Task(() => {
                dl.DoListen();
            });
            t.Start();
        }

        public void onHome(UserControl uc)
        {
            mainPanel1.Visible = true;
            uc.Visible = false;   
        }

        private void mainPanel1_Click1(object sender, System.EventArgs e)
        {
            inventoryPanel1.Visible = false;
            mainPanel1.commonCase.Enabled = true;
            mainPanel1.eliteBtn.Enabled = true;
            mainPanel1.nickName.Enabled = true;
        }

        private void mainForm_Resize(object sender, System.EventArgs e)
        {
            tray.BalloonTipTitle = "App was minimized to tray";
            tray.BalloonTipText = "Чтобы открыть окно дважды нажмите на иконку";

            if (FormWindowState.Minimized == this.WindowState)
            {
                tray.Visible = true;
                tray.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                tray.Visible = false;
            }
        }

        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }
    }
}

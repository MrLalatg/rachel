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
        public string donation_password;
        DonationListener dl;

        public System.Windows.Forms.PictureBox[,] eliteCards;
        public mainForm()
        {
            InitializeComponent();
            initializeDonation();
        }

        public delegate void InvokeDelegate(JObject donation );

        public void InvokeMethod( JObject donation)
        {
            overlay ol = new overlay();
            string username = donation["username"].ToString();
            User toRide = db.getUserByField(username);
            if(toRide == null)
            {
                toRide = new User() { Name = username };
                db.saveUser(toRide);
            }
            ol.Show();
            ol.ride(toRide);
        }


        public void initializeDonation()
        {
            donation_password = db.getPassword();
            dl = new DonationListener(donation_password);
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
    }
}

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
    public partial class commonPanel : UserControl
    {
        public List<PictureBox> pictBoxes;
        private Dictionary<int, PrizeItem> tempPrizes;
        public commonPanel()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                tempPrizes = db.getPrizes();

                pictBoxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21 };
                for (int i = 1; i <= pictBoxes.Count; i++)
                {
                    pictBoxes[i - 1].BackgroundImageLayout = ImageLayout.Stretch;
                    pictBoxes[i - 1].BackgroundImage = tempPrizes[i].Image;
                    pictBoxes[i - 1].Tag = tempPrizes[i];
                }
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).commonOpening1.Visible = true;
            this.Hide();
            User tempusr = db.getUserByField(((mainForm)Parent).currentNick);
            if (tempusr == null){
                tempusr = new User { Name = ((mainForm)Parent).currentNick };
            }
            ((mainForm)Parent).commonOpening1.ride(tempusr);
        }

    }
}

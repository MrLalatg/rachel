using System;
using System.Drawing;
using System.Windows.Forms;

namespace RacheM
{
    public partial class getPrize : UserControl
    {
        public getPrize()
        {
            InitializeComponent();
        }

        public void setPrize(int id)
        {
            prizeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            prizeImg.Image =  db.getPrizes()[id].Image;
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }
    }
}

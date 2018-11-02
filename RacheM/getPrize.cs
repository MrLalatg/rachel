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
    public partial class getPrize : UserControl
    {
        public getPrize()
        {
            InitializeComponent();
        }

        public void setPrize(Image img)
        {
            prizeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            prizeImg.Image = img;
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }
    }
}

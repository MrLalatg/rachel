using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RacheM
{
    public partial class getPrize : UserControl
    {
        private int prizeId;
        public getPrize()
        {
            InitializeComponent();
        }

        public void setPrize(int id)
        {
            prizeId = id;
            prizeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            prizeImg.Image =  db.getPrizes()[prizeId].Image;
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            User curUsr = db.getUserByField(((mainForm)Parent).currentNick);

            curUsr.prizes.RemoveAt(curUsr.prizes.FindLastIndex(p => p.Id == prizeId));
            db.saveUser(curUsr);

            ((mainForm)Parent).onHome(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RacheM
{
    public partial class eliteCase : UserControl
    {
        Random rnd = new Random();
        int[,] setka = new int[3, 3];
        int counter = 0;
        ArrayList tempRes = new ArrayList();
        public Image prize;
        public eliteCase()
        {
            InitializeComponent();
        }

        public void clickHandler(object sender, EventArgs e)
        {
            ((System.Windows.Forms.PictureBox)sender).Padding = new Padding(5);
            ((System.Windows.Forms.PictureBox)sender).BackColor = Color.Purple;
            ((System.Windows.Forms.PictureBox)sender).Image = (Image)((System.Windows.Forms.PictureBox)sender).Tag;
            ((System.Windows.Forms.PictureBox)sender).Enabled = false;
            tempRes.Add(((PictureBox)sender).Image);
            counter++;
            if (counter == 3)
            {
                if (tempRes[0] == tempRes[1] && tempRes[1] == tempRes[2] && tempRes[0] == tempRes[2])
                {
                    prize = (Image)tempRes[0];
                }
                else
                {
                    prize = ((mainForm)Parent).badPrizes[rnd.Next(1, 8)];
                }
                foreach(PictureBox i in ((mainForm)Parent).eliteCards)
                {
                    i.Image = (Image)i.Tag;
                }
                continueBtn.Visible = true;
            }
        }

        public void createPrize()
        {
            ((mainForm)Parent).eliteCards = new System.Windows.Forms.PictureBox[3, 3] { { square1_1, square1_2, square1_3 }, { square2_1, square2_2, square2_3 }, { square3_1, square3_2, square3_3 } };
            Array.Clear(setka, 0, setka.Length);
            ArrayList prizes = new ArrayList();
            while (prizes.Count !=3)
            {
                int temp;
                temp = rnd.Next(1, 9);
                if (!prizes.Contains(temp)){
                    prizes.Add(temp);
                }
            }

            if(rnd.Next(1, 101) == 7)
            {
                prizes[0] = 9;
            }

            int rnd1;
            int rnd2;

            foreach (int i in prizes) {
                for(int j = 0; j<=2; j++)
                {
                    rnd1 = rnd.Next(0, 3);
                    rnd2 = rnd.Next(0, 3);
                    if(setka[rnd1, rnd2] == 0)
                    {
                        setka[rnd1, rnd2] = i;
                    } else
                    {
                        j--;
                    }
                }
            }

            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    ((mainForm)Parent).eliteCards[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    ((mainForm)Parent).eliteCards[i, j].Tag = ((mainForm)Parent).prizes[setka[i, j]];
                }
            }

        }

        public void clear()
        {
            foreach(PictureBox i in ((mainForm)Parent).eliteCards)
            {
                i.Image = null;
                i.BackColor = Color.Transparent;
                i.Padding = new Padding(0);
                i.Enabled = true;
            }
            tempRes = new ArrayList();
            continueBtn.Visible = false;
            setka = new int[3, 3];
            counter = 0;
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
            clear();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            ((mainForm)Parent).getPrize1.setPrize(prize);
            ((mainForm)Parent).getPrize1.Visible = true;
            clear();
        }
    }
}

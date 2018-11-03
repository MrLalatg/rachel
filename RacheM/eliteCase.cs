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
        List<int> tempRes = new List<int>();
        public int prize;
        public eliteCase()
        {
            InitializeComponent();
        }

        public void clickHandler(object sender, EventArgs e)
        {
            int clickId = (int) ((Control) sender).Tag;
            ((PictureBox)sender).Padding = new Padding(5);
            ((PictureBox)sender).BackColor = Color.Purple;
            ((PictureBox) sender).Image = db.getPrizes()[clickId].Image; 
            ((PictureBox)sender).Enabled = false;
            
            tempRes.Add(clickId);
            counter++;
            if (counter == 3)
            {
                if (tempRes[0] == tempRes[1] && tempRes[1] == tempRes[2] && tempRes[0] == tempRes[2])
                {
                    prize = tempRes[0];
                }
                else
                {
                    int randomNumber = rnd.Next(1, 101);
                    if (randomNumber <= 80)
                    {
                        prize = getRandomForGroup(1, 1).First();

                    } else if (randomNumber <= 99)
                    {
                        prize = getRandomForGroup(0, 1).First();

                    }
                    else
                    {
                        prize = db.getPrizes().Where(p => p.Value.IsBad == 2).Select(p => p.Key).FirstOrDefault();
                    }
                }
                foreach(PictureBox i in ((mainForm)Parent).eliteCards)
                {
                    i.Image = db.getPrizes()[(int)i.Tag].Image;
                    i.Enabled = false;
                }
                continueBtn.Visible = true;
            }
        }

        private IEnumerable<int> getRandomForGroup(int isBad, int length)
        {
            return db.getPrizes()
                .Where(p => p.Value.IsBad == isBad)
                .Select(p => new {id = p.Key, ord = rnd.Next()})
                .OrderBy(p => p.ord)
                .Take(length)
                .Select(p => p.id);
        }


        public void createPrize()
        {
            ((mainForm)Parent).eliteCards = new System.Windows.Forms.PictureBox[3, 3] { { square1_1, square1_2, square1_3 }, { square2_1, square2_2, square2_3 }, { square3_1, square3_2, square3_3 } };
            Array.Clear(setka, 0, setka.Length);

            List<int> prizes = getRandomForGroup(0, 3).ToList();

            prizes[0] = rnd.Next(1, 101) == 7 
                ? db.getPrizes().Where(p=>p.Value.IsBad == 2).Select( p => p.Key).FirstOrDefault()
                : prizes[0];


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
                    ((mainForm)Parent).eliteCards[i, j].Tag = setka[i, j];
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
            tempRes.Clear();
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
            User plr = db.getUserByName(((mainForm) Parent).currentNick);
            if (plr == null)
            {
                plr = new User{Name = ((mainForm)Parent).currentNick};
            }
            plr.prizes.Add(db.getPrizes()[prize]);
            db.saveUser(plr);
            ((mainForm)Parent).getPrize1.Visible = true;
            clear();
        }
    }
}

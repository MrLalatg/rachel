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
    public partial class commonOpening : UserControl
    {
        public commonOpening()
        {
            InitializeComponent();
            ride();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ride()
        {
            this.roller.Image =  buildSausage(getRandomPrizes(100));
        }

        private List<PrizeItem> getRandomPrizes(int count)
        {
            List<PrizeItem> allPrizes= db.getPrizes().Where(p => p.Value.Type != 2).Select(p => p.Value).ToList();
            List<PrizeItem> result = new List<PrizeItem>();
            List<PrizeItem> tempres = new List<PrizeItem>();
            int r1 = (count / 100) * 60;
            int r2 = (count / 100) * 30;
            int r3 = (count / 100) * 8;
            Random rnd = new Random();

            for (int i = 0; i < r1; i++)
            {
                tempres = allPrizes.Where(p => p.IsBad == 3).ToList();
                result.Add(tempres[rnd.Next(0, tempres.Count)]);
            }
            
            for (int i = 0; i < r2; i++)
            {
                tempres = allPrizes.Where(p => p.IsBad == 2).ToList();
                result.Add(tempres[rnd.Next(0, tempres.Count)]);
            }
            
            for (int i = 0; i < r3; i++)
            {
                tempres = allPrizes.Where(p => p.IsBad == 1).ToList();
                result.Add(tempres[rnd.Next(0, tempres.Count)]);
            }

            if (rnd.Next(1, 1001) == 7)
            {
                result[rnd.Next(0, result.Count)] = db.getPrizes().Where(p => p.Value.Type == -1).Select(p => p.Value).FirstOrDefault();
            }

            return result;
        }

        private Image buildSausage(List<PrizeItem> prizes)
        {
            Image sausage = new Bitmap(170*prizes.Count, 170);
            Graphics g = Graphics.FromImage(sausage);
            for (int i = 0; i < prizes.Count; i++)
            {
                g.DrawImage(prizes[i].Image, new Point(170*i, 0));
            }

            return sausage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacheM
{
    public partial class overlay : Form
    {
        Random rnd = new Random();
        public overlay()
        {
            InitializeComponent();
        }

        public void ride(User curUsr, int prizeType = 0)
        {
            int ImageCount = 60;
            int ImageLength = 170;

            this.roller.Image = new Bitmap(1280, 170);
            Graphics gr = Graphics.FromImage(this.roller.Image);

            var randomPrizes = getRandomPrizes(ImageCount);
            Image LongImage = buildSausage(randomPrizes, ImageLength);

            int speed = 30;

            int endPtr = ImageLength * ImageCount;

            bool beginStop = false;

            int i;
            for (i = 0; i < endPtr; i += speed)
            {
                gr.DrawImage(LongImage, new Rectangle(0, 0, 1280, 170), new Rectangle(i, 0, 1280, 170), GraphicsUnit.Pixel);
                roller.Refresh();

                speed = (int)((Math.Cos((i * Math.PI) / (ImageLength * ImageCount)) + 1) * 15);
                if (speed == 1 && !beginStop)
                {
                    beginStop = true;
                    endPtr = i + rnd.Next(10, 160);
                }
            }

           curUsr.prizes.Add(randomPrizes[(i + 1280 / 2) / 170]);
           db.saveUser(curUsr);
            this.Hide();

        }

        private List<PrizeItem> getRandomPrizes(int count)
        {
            List<PrizeItem> allPrizes = db.getPrizes().Where(p => p.Value.Type != 2).Select(p => p.Value).ToList();
            List<PrizeItem> result = new List<PrizeItem>();
            List<PrizeItem> tempres = new List<PrizeItem>();
            int r1 = (int)((count / 100M) * 60);
            int r2 = (int)((count / 100M) * 30);
            int r3 = (int)((count / 100M) * 8);

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


            return result.Select(r => new { item = r, ord = rnd.Next() }).OrderBy(r => r.ord).Select(r => r.item).ToList();
        }

        private Image buildSausage(List<PrizeItem> prizes, int imageLength)
        {
            Image sausage = new Bitmap(170 * prizes.Count, imageLength);
            Graphics g = Graphics.FromImage(sausage);
            for (int i = 0; i < prizes.Count; i++)
            {
                g.DrawImage(prizes[i].Image, new Rectangle(imageLength * i, 0, imageLength, imageLength));
            }
            return sausage;
        }

    }
}

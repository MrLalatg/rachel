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
    public partial class mainForm : Form
    {
        public string backAdress;
        public string currentNick;
        public Dictionary<int, Bitmap> prizes = new Dictionary<int, Bitmap>
        {
            {1, Properties.Resources.room},
            {2, Properties.Resources.shirt},
            {3, Properties.Resources.vs},
            {4, Properties.Resources.znak},
            {5, Properties.Resources.magnet},
            {6, Properties.Resources.cup},
            {7, Properties.Resources.bank},
            {8, Properties.Resources.brelok},
            {9, Properties.Resources.knife}
        };

        public Dictionary<int, Bitmap> badPrizes = new Dictionary<int, Bitmap>
        {
            {1, Properties.Resources.invite},
            {2, Properties.Resources.chair},
            {3, Properties.Resources.likes},
            {4, Properties.Resources.nametag},
            {5, Properties.Resources.smile},
            {6, Properties.Resources.soc},
            {7, Properties.Resources.spons}
        };

        /*public Dictionary<Image, string> prizesText = new Dictionary<Image, string>
        {
            {Properties.Resources.bank },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { },
            { }
        };*/
        public System.Windows.Forms.PictureBox[,] eliteCards;
        public mainForm()
        {
            InitializeComponent();;
        }

        public void onHome(UserControl uc)
        {
            mainPanel1.Visible = true;
            uc.Visible = false;   
        }
    }
}

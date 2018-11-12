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
    public partial class prizesPanel : UserControl
    {
        public List<Button> buttons;
        private Dictionary<int, PrizeItem> tempPrizes;
        private PrizeItem currentPrize;
        private string currentNick = "";
        public prizesPanel()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                tempPrizes = db.getPrizes();

                buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29 };
                for (int i = 1; i <= buttons.Count; i++)
                {
                    buttons[i - 1].BackgroundImageLayout = ImageLayout.Stretch;
                    buttons[i - 1].BackgroundImage = tempPrizes[i].Image;
                    buttons[i - 1].Tag = tempPrizes[i];
                }
            }
        }

        public void onPrize(object sender, EventArgs e)
        {
            if (prize.Visible)
            {
                prize.Visible = false;
            }
            else
            {
                players.Items.Clear();
                currentPrize = ((PrizeItem)((Button)sender).Tag);
                if (currentPrize.Name.Contains("Комната") || currentPrize.Name.Contains("Комната"))
                {
                    roomBtn.Visible = true;
                } else
                {
                    roomBtn.Visible = false;
                }
                foreach (User i in db.getPrizePlayers(currentPrize.Id))
                {
                    players.Items.Add(i.Name);
                }

                prize.Visible = true;
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }

        private void prizesPanel_Click(object sender, EventArgs e)
        {
            prize.Visible = false;
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            User curUsr = new User();

            foreach (string i in players.CheckedItems)
            {
                curUsr = db.getUserByField(i);
                curUsr.prizes.RemoveAt(curUsr.prizes.FindLastIndex(p => p == currentPrize));
                db.saveUser(curUsr);
            }

            players.Items.Clear();

            foreach (User i in db.getPrizePlayers(currentPrize.Id))
            {
                players.Items.Add(i.Name);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(currentNick != "")
            {
                User curUsr = db.getUserByField(currentNick) == null ? new User { Name = currentNick } : db.getUserByField(currentNick);

                curUsr.prizes.Add(currentPrize);
                db.saveUser(curUsr);

                players.Items.Clear();

                foreach (User i in db.getPrizePlayers(currentPrize.Id))
                {
                    players.Items.Add(i.Name);
                }
            }
        }

        private void nick_TextChanged(object sender, EventArgs e)
        {
            currentNick = nick.Text;
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            prize.Hide();
            this.Hide();
            switch (currentPrize.Name)
            {
                case "Золотая Комната":
                    ((mainForm)Parent).room1.init(0);
                    break;
                case "Платиновая Комната":
                    ((mainForm)Parent).room1.init(1);
                    break;
            }
            ((mainForm)Parent).room1.Visible = true;
        }
    }
}

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
    public partial class mainPanel : UserControl
    {
        public mainPanel()
        {
            InitializeComponent();
        }

        private void commonCase_Click(object sender, EventArgs e)
        {
            if (((mainForm)Parent).currentNick == null || ((mainForm)Parent).currentNick == "")
            {
                error.Visible = true;
            } else
            {
                error.Visible = false;
                Visible = false;
                ((mainForm)Parent).commonPanel1.Visible = true;
            }
        }

        private void eliteBtn_Click(object sender, EventArgs e)
        {
            if (((mainForm)Parent).currentNick == null || ((mainForm)Parent).currentNick == "")
            {
                error.Visible = true;
            } else
            {
                error.Visible = false;
                Visible = false;
                ((mainForm)Parent).eliteCase1.createPrize();
                ((mainForm)Parent).eliteCase1.Visible = true;
            }
        }

        private void nickName_TextChanged(object sender, EventArgs e)
        {
            ((mainForm)Parent).currentNick = nickName.Text;
            error.Visible = false;
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            if (((mainForm)Parent).currentNick == null || ((mainForm)Parent).currentNick == "")
            {
                error.Visible = true;
            } else {
                error.Visible = false;
                User currentPlayer = db.getUserByField(((mainForm)Parent).currentNick);
                if (currentPlayer == null)
                {
                    currentPlayer = new User { Name = ((mainForm)Parent).currentNick };
                }
                db.saveUser(currentPlayer);
                ((mainForm)Parent).inventoryPanel1.setUser(currentPlayer);
                ((mainForm)Parent).inventoryPanel1.Visible = !((mainForm)Parent).inventoryPanel1.Visible;
                commonCase.Enabled = false;
                eliteBtn.Enabled = false;
                nickName.Enabled = false;
            }
        }

        private void showPrizesBtn_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).prizesPanel1.Visible = true;
        }
    }
}

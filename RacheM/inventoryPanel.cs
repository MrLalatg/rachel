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
    public partial class inventoryPanel : UserControl
    {
        private User curUsr;
        public inventoryPanel()
        {
            InitializeComponent();
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            curUsr.prizes = curUsr.prizes.Where(p => !prizeItems.CheckedItems.Contains(p.Name)).ToList();
            db.saveUser(curUsr);
            setUser(curUsr);
        }

        public void setUser(User usr)
        {
            prizeItems.Items.Clear();
            foreach (PrizeItem i in usr.prizes)
            {
                ((mainForm)Parent).inventoryPanel1.prizeItems.Items.Add(i.Name);
            }
            curUsr = usr;
        }
    }
}

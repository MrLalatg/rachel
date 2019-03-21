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
    public partial class commonPanel : UserControl
    {
        public commonPanel()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).onHome(this);
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            ((mainForm)Parent).commonOpening1.Visible = true;
            this.Hide();
            User tempusr = db.getUserByField(((mainForm)Parent).currentNick);
            if (tempusr == null){
                tempusr = new User { Name = ((mainForm)Parent).currentNick };
                db.saveUser(tempusr);
            }
            ((mainForm)Parent).commonOpening1.ride(tempusr);
        }

    }
}

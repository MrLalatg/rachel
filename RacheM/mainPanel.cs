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
        public mainForm cp1 { get; set; }
        public mainPanel()
        {
            InitializeComponent();
        }

        private void commonCase_Click(object sender, EventArgs e)
        {
            ((mainForm)this.Parent).commonPanel1.Visible = true;
        }
    }
}

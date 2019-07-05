using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacheM
{
    public partial class Logger : Form
    {
        private List<LogEntry> logs = new List<LogEntry>();
        private Font labelFont = new Font("Arial", 15);

        public Logger()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void Logger_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        public void AddEntry(User user, PrizeItem prize)
        {

            if (prize.Unique && logs.FindLastIndex(log => log.prize.Name == prize.Name && log.user.Name == user.Name) != -1)
            {
                return;
            }

            LogEntry newEntry = new LogEntry(user, prize);
            logs.Add(newEntry);

            Button confirm = new Button()
            {
                BackColor = Color.Transparent,
                Size = new Size(25, 25),
                Tag = newEntry,
                BackgroundImage = RacheM.Properties.Resources.actionIcon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Fill,
                TabStop = false,
            };

            confirm.Click += Confirm_Click;

            TextBox nickLabel = new TextBox() { Text = newEntry.user.Name, Font = labelFont, Dock = DockStyle.Fill, ReadOnly = true, TabStop = false };
            TextBox prizeLabel = new TextBox() { Text = newEntry.prize.Name, Font = labelFont, Dock = DockStyle.Fill, ReadOnly = true, TabStop = false, };
            prizeLabel.Margin = new Padding(3, 3, 5, 3);

            Size lastSize = this.tableLayoutPanel1.Size;

            Point lastScrollPosition = this.AutoScrollPosition;

            lastScrollPosition.Y = Math.Abs(lastScrollPosition.Y);

            if(logs.Count != 1)
            {
                this.tableLayoutPanel1.RowCount++;
            }
            this.tableLayoutPanel1.SuspendLayout();
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                int curRow = this.tableLayoutPanel1.GetRow(c);
                if (curRow != 0)
                {
                    this.tableLayoutPanel1.SetRow(c, curRow + 1);
                }
            }
            this.tableLayoutPanel1.Controls.Add(nickLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(prizeLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(confirm, 0, 1);
            this.tableLayoutPanel1.ResumeLayout();
            this.AutoScrollPosition = lastScrollPosition;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Button curBtn = ((Button)sender);
            curBtn.Click -= Confirm_Click;
            curBtn.ForeColor = Color.Gray;
            curBtn.BackgroundImage = RacheM.Properties.Resources.checkIcon;
            User user = ((LogEntry)(curBtn.Tag)).user;
            PrizeItem prize = ((LogEntry)(curBtn.Tag)).prize;
            db.deletePrizeFromPlayer(user, prize);
        }
    }
}

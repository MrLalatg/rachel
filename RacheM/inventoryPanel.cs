﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RacheM
{
    public partial class inventoryPanel : UserControl
    {
        private User curUsr;
        Dictionary<int, PrizeItem> tempPrizes;
        public inventoryPanel()
        {
            InitializeComponent();
            if(LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                tempPrizes = db.getPrizes();
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            foreach(string i in prizeItems.CheckedItems)
            {
                db.deletePrizeFromPlayer(curUsr, db.prizesByName[i]);
            }
            setUser(curUsr);
        }

        public void setUser(User usr)
        {
            prizeItems.Items.Clear();
            addPick.Items.Clear();

            string tempName = usr.Name;
            usr = db.getUserByField(usr.Name);

            if(usr == null)
            {
                usr = new User() { Name = tempName, prizes = new List<PrizeItem>() };
            }

            foreach (PrizeItem i in usr.prizes)
            {
                ((mainForm)Parent).inventoryPanel1.prizeItems.Items.Add(i.Name);
            }
            curUsr = usr;

            foreach(int i in tempPrizes.Keys)
            {
                addPick.Items.Add(new ComboboxItem(tempPrizes[i].Name, i));
            }

            addPick.SelectedItem = addPick.Items[0];
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.addPrizeToPlayer(curUsr, tempPrizes[(int)((ComboboxItem)addPick.SelectedItem).Value]);
            setUser(curUsr);
        }
    }
}

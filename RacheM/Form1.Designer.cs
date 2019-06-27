namespace RacheM
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.commonOpening1 = new RacheM.commonOpening();
            this.settings_panel1 = new RacheM.settings_panel();
            this.informPanel1 = new RacheM.informPanel();
            this.roomres1 = new RacheM.roomres();
            this.room1 = new RacheM.room();
            this.prizesPanel1 = new RacheM.prizesPanel();
            this.inventoryPanel1 = new RacheM.inventoryPanel();
            this.getPrize1 = new RacheM.getPrize();
            this.commonPanel1 = new RacheM.commonPanel();
            this.mainPanel1 = new RacheM.mainPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.contextMenuStrip1;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Rachel Case";
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // commonOpening1
            // 
            this.commonOpening1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commonOpening1.BackgroundImage")));
            this.commonOpening1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commonOpening1.Location = new System.Drawing.Point(0, 0);
            this.commonOpening1.Name = "commonOpening1";
            this.commonOpening1.Size = new System.Drawing.Size(1280, 720);
            this.commonOpening1.TabIndex = 12;
            this.commonOpening1.Visible = false;
            // 
            // settings_panel1
            // 
            this.settings_panel1.BackColor = System.Drawing.Color.Black;
            this.settings_panel1.Location = new System.Drawing.Point(0, 0);
            this.settings_panel1.Name = "settings_panel1";
            this.settings_panel1.Size = new System.Drawing.Size(1280, 720);
            this.settings_panel1.TabIndex = 10;
            this.settings_panel1.Visible = false;
            // 
            // informPanel1
            // 
            this.informPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("informPanel1.BackgroundImage")));
            this.informPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informPanel1.Location = new System.Drawing.Point(0, 0);
            this.informPanel1.Name = "informPanel1";
            this.informPanel1.Size = new System.Drawing.Size(1280, 720);
            this.informPanel1.TabIndex = 9;
            this.informPanel1.Visible = false;
            // 
            // roomres1
            // 
            this.roomres1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomres1.BackgroundImage")));
            this.roomres1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roomres1.Location = new System.Drawing.Point(0, 0);
            this.roomres1.Name = "roomres1";
            this.roomres1.Size = new System.Drawing.Size(1280, 720);
            this.roomres1.TabIndex = 8;
            this.roomres1.Visible = false;
            // 
            // room1
            // 
            this.room1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("room1.BackgroundImage")));
            this.room1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1.Location = new System.Drawing.Point(0, 0);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(1280, 720);
            this.room1.TabIndex = 6;
            this.room1.Visible = false;
            // 
            // prizesPanel1
            // 
            this.prizesPanel1.BackgroundImage = global::RacheM.Properties.Resources.str5;
            this.prizesPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prizesPanel1.Location = new System.Drawing.Point(0, 0);
            this.prizesPanel1.Name = "prizesPanel1";
            this.prizesPanel1.Size = new System.Drawing.Size(1280, 720);
            this.prizesPanel1.TabIndex = 5;
            this.prizesPanel1.Visible = false;
            // 
            // inventoryPanel1
            // 
            this.inventoryPanel1.BackColor = System.Drawing.Color.Transparent;
            this.inventoryPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventoryPanel1.BackgroundImage")));
            this.inventoryPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryPanel1.Location = new System.Drawing.Point(927, 0);
            this.inventoryPanel1.Name = "inventoryPanel1";
            this.inventoryPanel1.Size = new System.Drawing.Size(353, 720);
            this.inventoryPanel1.TabIndex = 4;
            this.inventoryPanel1.Visible = false;
            // 
            // getPrize1
            // 
            this.getPrize1.BackColor = System.Drawing.Color.Transparent;
            this.getPrize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getPrize1.BackgroundImage")));
            this.getPrize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getPrize1.Location = new System.Drawing.Point(0, 0);
            this.getPrize1.Name = "getPrize1";
            this.getPrize1.Size = new System.Drawing.Size(1280, 720);
            this.getPrize1.TabIndex = 3;
            this.getPrize1.Visible = false;
            // 
            // commonPanel1
            // 
            this.commonPanel1.BackColor = System.Drawing.Color.Transparent;
            this.commonPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commonPanel1.BackgroundImage")));
            this.commonPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commonPanel1.Location = new System.Drawing.Point(0, 0);
            this.commonPanel1.Name = "commonPanel1";
            this.commonPanel1.Size = new System.Drawing.Size(1280, 720);
            this.commonPanel1.TabIndex = 1;
            this.commonPanel1.Visible = false;
            // 
            // mainPanel1
            // 
            this.mainPanel1.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel1.BackgroundImage")));
            this.mainPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(1280, 720);
            this.mainPanel1.TabIndex = 11;
            this.mainPanel1.Click += new System.EventHandler(this.mainPanel1_Click1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.развернутьToolStripMenuItem.Text = "Развернуть";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.выйтиToolStripMenuItem.Text = "Выход";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.commonOpening1);
            this.Controls.Add(this.settings_panel1);
            this.Controls.Add(this.informPanel1);
            this.Controls.Add(this.roomres1);
            this.Controls.Add(this.room1);
            this.Controls.Add(this.prizesPanel1);
            this.Controls.Add(this.inventoryPanel1);
            this.Controls.Add(this.getPrize1);
            this.Controls.Add(this.commonPanel1);
            this.Controls.Add(this.mainPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RachelR Case";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public commonPanel commonPanel1;
        public getPrize getPrize1;
        public inventoryPanel inventoryPanel1;
        public prizesPanel prizesPanel1;
        public room room1;
        public roomres roomres1;
        public informPanel informPanel1;
        public settings_panel settings_panel1;
        private System.Windows.Forms.NotifyIcon tray;
        public mainPanel mainPanel1;
        public commonOpening commonOpening1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    }
}


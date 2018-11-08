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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.room1 = new RacheM.room();
            this.prizesPanel1 = new RacheM.prizesPanel();
            this.inventoryPanel1 = new RacheM.inventoryPanel();
            this.getPrize1 = new RacheM.getPrize();
            this.eliteCase1 = new RacheM.eliteCase();
            this.commonPanel1 = new RacheM.commonPanel();
            this.mainPanel1 = new RacheM.mainPanel();
            this.SuspendLayout();
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
            this.prizesPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prizesPanel1.BackgroundImage")));
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
            // eliteCase1
            // 
            this.eliteCase1.BackColor = System.Drawing.Color.Transparent;
            this.eliteCase1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliteCase1.BackgroundImage")));
            this.eliteCase1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliteCase1.Location = new System.Drawing.Point(0, 0);
            this.eliteCase1.Name = "eliteCase1";
            this.eliteCase1.Size = new System.Drawing.Size(1280, 720);
            this.eliteCase1.TabIndex = 2;
            this.eliteCase1.Visible = false;
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
            this.mainPanel1.TabIndex = 0;
            this.mainPanel1.Click += new System.EventHandler(this.mainPanel1_Click1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.room1);
            this.Controls.Add(this.prizesPanel1);
            this.Controls.Add(this.inventoryPanel1);
            this.Controls.Add(this.getPrize1);
            this.Controls.Add(this.eliteCase1);
            this.Controls.Add(this.commonPanel1);
            this.Controls.Add(this.mainPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public mainPanel mainPanel1;
        public commonPanel commonPanel1;
        public eliteCase eliteCase1;
        public getPrize getPrize1;
        public inventoryPanel inventoryPanel1;
        public prizesPanel prizesPanel1;
        public room room1;
    }
}


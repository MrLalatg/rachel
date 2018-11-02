namespace RacheM
{
    partial class getPrize
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prizeImg = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prizeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // prizeImg
            // 
            this.prizeImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prizeImg.Location = new System.Drawing.Point(480, 86);
            this.prizeImg.Name = "prizeImg";
            this.prizeImg.Size = new System.Drawing.Size(352, 352);
            this.prizeImg.TabIndex = 0;
            this.prizeImg.TabStop = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BackgroundImage = global::RacheM.Properties.Resources.home;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Location = new System.Drawing.Point(78, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(72, 72);
            this.home.TabIndex = 3;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::RacheM.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(72, 72);
            this.back.TabIndex = 2;
            this.back.UseVisualStyleBackColor = false;
            // 
            // getPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::RacheM.Properties.Resources.getPrize;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.home);
            this.Controls.Add(this.back);
            this.Controls.Add(this.prizeImg);
            this.Name = "getPrize";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.prizeImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox prizeImg;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button back;
    }
}

namespace RacheM
{
    partial class commonPanel
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
            this.home = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(72, 72);
            this.home.TabIndex = 1;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // openBtn
            // 
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Location = new System.Drawing.Point(506, 484);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(323, 77);
            this.openBtn.TabIndex = 2;
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RacheM.Properties.Resources.yDw9ixa1ppg;
            this.pictureBox1.Location = new System.Drawing.Point(519, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RacheM.Properties.Resources.qccg8zaFwRI;
            this.pictureBox2.Location = new System.Drawing.Point(380, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // commonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::RacheM.Properties.Resources.commonCase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.home);
            this.Name = "commonPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

﻿namespace RacheM
{
    partial class informPanel
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
            this.mrlalatgBtn = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.rachelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mrlalatgBtn
            // 
            this.mrlalatgBtn.BackColor = System.Drawing.Color.Transparent;
            this.mrlalatgBtn.FlatAppearance.BorderSize = 0;
            this.mrlalatgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mrlalatgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mrlalatgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrlalatgBtn.Location = new System.Drawing.Point(278, 206);
            this.mrlalatgBtn.Name = "mrlalatgBtn";
            this.mrlalatgBtn.Size = new System.Drawing.Size(731, 124);
            this.mrlalatgBtn.TabIndex = 0;
            this.mrlalatgBtn.UseVisualStyleBackColor = false;
            this.mrlalatgBtn.Click += new System.EventHandler(this.mrlalatgBtn_Click);
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
            this.home.TabIndex = 30;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // rachelBtn
            // 
            this.rachelBtn.BackColor = System.Drawing.Color.Transparent;
            this.rachelBtn.FlatAppearance.BorderSize = 0;
            this.rachelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rachelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rachelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rachelBtn.Location = new System.Drawing.Point(338, 447);
            this.rachelBtn.Name = "rachelBtn";
            this.rachelBtn.Size = new System.Drawing.Size(612, 122);
            this.rachelBtn.TabIndex = 31;
            this.rachelBtn.UseVisualStyleBackColor = false;
            this.rachelBtn.Click += new System.EventHandler(this.rachelBtn_Click);
            // 
            // informPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RacheM.Properties.Resources.infP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rachelBtn);
            this.Controls.Add(this.home);
            this.Controls.Add(this.mrlalatgBtn);
            this.Name = "informPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mrlalatgBtn;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button rachelBtn;
    }
}

﻿namespace RacheM
{
    partial class overlay
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
            this.roller = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nickname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roller)).BeginInit();
            this.SuspendLayout();
            // 
            // roller
            // 
            this.roller.BackColor = System.Drawing.Color.White;
            this.roller.Location = new System.Drawing.Point(0, 0);
            this.roller.Name = "roller";
            this.roller.Size = new System.Drawing.Size(1280, 170);
            this.roller.TabIndex = 1;
            this.roller.TabStop = false;
            this.roller.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(635, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 170);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // nickname
            // 
            this.nickname.BackColor = System.Drawing.Color.Lime;
            this.nickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nickname.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickname.ForeColor = System.Drawing.Color.Orange;
            this.nickname.Location = new System.Drawing.Point(0, 176);
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.Size = new System.Drawing.Size(1280, 77);
            this.nickname.TabIndex = 3;
            this.nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nickname.Visible = false;
            // 
            // overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1280, 270);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roller);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "overlay";
            this.Text = "overlay";
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.roller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox roller;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox nickname;
    }
}
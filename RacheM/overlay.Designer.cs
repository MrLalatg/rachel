namespace RacheM
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
            this.sdlPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.roller)).BeginInit();
            this.sdlPanel.SuspendLayout();
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
            // sdlPanel
            // 
            this.sdlPanel.Controls.Add(this.listBox1);
            this.sdlPanel.Location = new System.Drawing.Point(0, 0);
            this.sdlPanel.Name = "sdlPanel";
            this.sdlPanel.Size = new System.Drawing.Size(1280, 570);
            this.sdlPanel.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Lime;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Orange;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Location = new System.Drawing.Point(1103, 326);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 245);
            this.listBox1.TabIndex = 0;
            // 
            // overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1280, 570);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sdlPanel);
            this.Controls.Add(this.roller);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "overlay";
            this.Text = "overlay";
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.roller)).EndInit();
            this.sdlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox roller;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Panel sdlPanel;
        private System.Windows.Forms.ListBox listBox1;
    }
}
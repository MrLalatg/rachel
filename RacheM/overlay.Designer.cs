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
            this.sdlPanel = new System.Windows.Forms.Panel();
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
            // sdlPanel
            // 
            this.sdlPanel.Location = new System.Drawing.Point(0, 0);
            this.sdlPanel.Name = "sdlPanel";
            this.sdlPanel.Size = new System.Drawing.Size(1280, 791);
            this.sdlPanel.TabIndex = 4;
            // 
            // overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1280, 756);
            this.Controls.Add(this.sdlPanel);
            this.Controls.Add(this.roller);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "overlay";
            this.Text = "overlay";
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.roller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox roller;
        private System.Windows.Forms.Panel sdlPanel;
    }
}
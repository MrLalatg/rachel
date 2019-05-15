namespace RacheM
{
    partial class commonOpening
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
            this.roller = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sdlPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.roller)).BeginInit();
            this.SuspendLayout();
            // 
            // roller
            // 
            this.roller.Location = new System.Drawing.Point(0, 274);
            this.roller.Name = "roller";
            this.roller.Size = new System.Drawing.Size(1280, 170);
            this.roller.TabIndex = 0;
            this.roller.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(637, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 170);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sdlPanel
            // 
            this.sdlPanel.Location = new System.Drawing.Point(0, 274);
            this.sdlPanel.Name = "sdlPanel";
            this.sdlPanel.Size = new System.Drawing.Size(1280, 170);
            this.sdlPanel.TabIndex = 2;
            // 
            // commonOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RacheM.Properties.Resources.roll;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sdlPanel);
            this.Controls.Add(this.roller);
            this.Name = "commonOpening";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.roller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox roller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sdlPanel;
    }
}

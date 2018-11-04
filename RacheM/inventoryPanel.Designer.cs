namespace RacheM
{
    partial class inventoryPanel
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
            this.prizeItems = new System.Windows.Forms.CheckedListBox();
            this.completeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prizeItems
            // 
            this.prizeItems.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold);
            this.prizeItems.FormattingEnabled = true;
            this.prizeItems.Location = new System.Drawing.Point(18, 17);
            this.prizeItems.Name = "prizeItems";
            this.prizeItems.Size = new System.Drawing.Size(308, 599);
            this.prizeItems.TabIndex = 0;
            // 
            // completeBtn
            // 
            this.completeBtn.BackColor = System.Drawing.Color.Black;
            this.completeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.completeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBtn.ForeColor = System.Drawing.Color.Lime;
            this.completeBtn.Location = new System.Drawing.Point(181, 622);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(145, 31);
            this.completeBtn.TabIndex = 1;
            this.completeBtn.Text = "Выполнить";
            this.completeBtn.UseVisualStyleBackColor = false;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // inventoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::RacheM.Properties.Resources.inventory1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.prizeItems);
            this.DoubleBuffered = true;
            this.Name = "inventoryPanel";
            this.Size = new System.Drawing.Size(353, 720);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox prizeItems;
        private System.Windows.Forms.Button completeBtn;
    }
}

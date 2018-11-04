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
            this.addBtn = new System.Windows.Forms.Button();
            this.addPick = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // prizeItems
            // 
            this.prizeItems.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold);
            this.prizeItems.FormattingEnabled = true;
            this.prizeItems.Location = new System.Drawing.Point(23, 17);
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
            this.completeBtn.Location = new System.Drawing.Point(186, 622);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(145, 38);
            this.completeBtn.TabIndex = 1;
            this.completeBtn.Text = "Выполнить";
            this.completeBtn.UseVisualStyleBackColor = false;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.addBtn.Location = new System.Drawing.Point(23, 622);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(145, 38);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addPick
            // 
            this.addPick.BackColor = System.Drawing.Color.White;
            this.addPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPick.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPick.FormattingEnabled = true;
            this.addPick.Location = new System.Drawing.Point(23, 666);
            this.addPick.Name = "addPick";
            this.addPick.Size = new System.Drawing.Size(145, 26);
            this.addPick.TabIndex = 3;
            // 
            // inventoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::RacheM.Properties.Resources.inventory1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.addPick);
            this.Controls.Add(this.addBtn);
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
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox addPick;
    }
}

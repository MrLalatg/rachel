namespace RacheM
{
    partial class roomres
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
            this.nickBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nickBox
            // 
            this.nickBox.BackColor = System.Drawing.Color.Black;
            this.nickBox.Enabled = false;
            this.nickBox.Font = new System.Drawing.Font("Caviar Dreams", 111.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickBox.ForeColor = System.Drawing.Color.Firebrick;
            this.nickBox.Location = new System.Drawing.Point(275, 213);
            this.nickBox.Name = "nickBox";
            this.nickBox.Size = new System.Drawing.Size(732, 179);
            this.nickBox.TabIndex = 0;
            this.nickBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Transparent;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(572, 431);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(132, 79);
            this.okBtn.TabIndex = 1;
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // roomres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RacheM.Properties.Resources.roomresult;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.nickBox);
            this.Name = "roomres";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nickBox;
        private System.Windows.Forms.Button okBtn;
    }
}

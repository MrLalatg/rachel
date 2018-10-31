namespace RacheM
{
    partial class mainPanel
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
            this.commonCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commonCase
            // 
            this.commonCase.BackColor = System.Drawing.Color.Transparent;
            this.commonCase.FlatAppearance.BorderSize = 0;
            this.commonCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.commonCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.commonCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commonCase.Location = new System.Drawing.Point(747, 425);
            this.commonCase.Name = "commonCase";
            this.commonCase.Size = new System.Drawing.Size(212, 154);
            this.commonCase.TabIndex = 0;
            this.commonCase.UseVisualStyleBackColor = false;
            this.commonCase.Click += new System.EventHandler(this.commonCase_Click);
            // 
            // mainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RacheM.Properties.Resources.Главная;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.commonCase);
            this.Name = "mainPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button commonCase;
    }
}

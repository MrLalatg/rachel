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
            this.eliteBtn = new System.Windows.Forms.Button();
            this.nickName = new System.Windows.Forms.TextBox();
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
            // eliteBtn
            // 
            this.eliteBtn.FlatAppearance.BorderSize = 0;
            this.eliteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eliteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eliteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliteBtn.Location = new System.Drawing.Point(288, 414);
            this.eliteBtn.Name = "eliteBtn";
            this.eliteBtn.Size = new System.Drawing.Size(243, 176);
            this.eliteBtn.TabIndex = 1;
            this.eliteBtn.UseVisualStyleBackColor = true;
            this.eliteBtn.Click += new System.EventHandler(this.eliteBtn_Click);
            // 
            // nickName
            // 
            this.nickName.BackColor = System.Drawing.Color.Black;
            this.nickName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nickName.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickName.ForeColor = System.Drawing.Color.White;
            this.nickName.Location = new System.Drawing.Point(281, 238);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(400, 33);
            this.nickName.TabIndex = 2;
            this.nickName.TextChanged += new System.EventHandler(this.nickName_TextChanged);
            // 
            // mainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::RacheM.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.eliteBtn);
            this.Controls.Add(this.commonCase);
            this.Name = "mainPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commonCase;
        private System.Windows.Forms.Button eliteBtn;
        private System.Windows.Forms.TextBox nickName;
    }
}

namespace RacheM
{
    partial class settings_panel
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
            this.home = new System.Windows.Forms.Button();
            this.donPassword = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.home.TabIndex = 31;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // donPassword
            // 
            this.donPassword.BackColor = System.Drawing.Color.White;
            this.donPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donPassword.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donPassword.Location = new System.Drawing.Point(395, 195);
            this.donPassword.Name = "donPassword";
            this.donPassword.PasswordChar = '*';
            this.donPassword.Size = new System.Drawing.Size(507, 34);
            this.donPassword.TabIndex = 32;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Black;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Lime;
            this.saveBtn.Location = new System.Drawing.Point(588, 250);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(145, 38);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settings_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.donPassword);
            this.Controls.Add(this.home);
            this.Name = "settings_panel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button home;
        public System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.TextBox donPassword;
    }
}

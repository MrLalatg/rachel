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
            this.donTokenLabel = new System.Windows.Forms.TextBox();
            this.chNmLabel = new System.Windows.Forms.TextBox();
            this.channelName = new System.Windows.Forms.TextBox();
            this.botUsrNmLabel = new System.Windows.Forms.TextBox();
            this.botUsername = new System.Windows.Forms.TextBox();
            this.botTokLabel = new System.Windows.Forms.TextBox();
            this.botToken = new System.Windows.Forms.TextBox();
            this.clientIdLabel = new System.Windows.Forms.TextBox();
            this.clientId = new System.Windows.Forms.TextBox();
            this.fps_limit = new System.Windows.Forms.TextBox();
            this.fps_value = new System.Windows.Forms.ComboBox();
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
            this.donPassword.Location = new System.Drawing.Point(446, 97);
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
            this.saveBtn.Location = new System.Drawing.Point(446, 430);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(145, 38);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // donTokenLabel
            // 
            this.donTokenLabel.BackColor = System.Drawing.Color.Black;
            this.donTokenLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donTokenLabel.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donTokenLabel.ForeColor = System.Drawing.Color.White;
            this.donTokenLabel.Location = new System.Drawing.Point(97, 100);
            this.donTokenLabel.Name = "donTokenLabel";
            this.donTokenLabel.ReadOnly = true;
            this.donTokenLabel.Size = new System.Drawing.Size(316, 29);
            this.donTokenLabel.TabIndex = 34;
            this.donTokenLabel.Text = "DonationAlerts Token:";
            // 
            // chNmLabel
            // 
            this.chNmLabel.BackColor = System.Drawing.Color.Black;
            this.chNmLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chNmLabel.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNmLabel.ForeColor = System.Drawing.Color.White;
            this.chNmLabel.Location = new System.Drawing.Point(216, 153);
            this.chNmLabel.Name = "chNmLabel";
            this.chNmLabel.ReadOnly = true;
            this.chNmLabel.Size = new System.Drawing.Size(197, 29);
            this.chNmLabel.TabIndex = 36;
            this.chNmLabel.Text = "Channel Name:";
            // 
            // channelName
            // 
            this.channelName.BackColor = System.Drawing.Color.White;
            this.channelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.channelName.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelName.Location = new System.Drawing.Point(446, 150);
            this.channelName.Name = "channelName";
            this.channelName.Size = new System.Drawing.Size(507, 34);
            this.channelName.TabIndex = 35;
            // 
            // botUsrNmLabel
            // 
            this.botUsrNmLabel.BackColor = System.Drawing.Color.Black;
            this.botUsrNmLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.botUsrNmLabel.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botUsrNmLabel.ForeColor = System.Drawing.Color.White;
            this.botUsrNmLabel.Location = new System.Drawing.Point(217, 208);
            this.botUsrNmLabel.Name = "botUsrNmLabel";
            this.botUsrNmLabel.ReadOnly = true;
            this.botUsrNmLabel.Size = new System.Drawing.Size(196, 29);
            this.botUsrNmLabel.TabIndex = 38;
            this.botUsrNmLabel.Text = "Bot Username:";
            // 
            // botUsername
            // 
            this.botUsername.BackColor = System.Drawing.Color.White;
            this.botUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.botUsername.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botUsername.Location = new System.Drawing.Point(446, 205);
            this.botUsername.Name = "botUsername";
            this.botUsername.Size = new System.Drawing.Size(507, 34);
            this.botUsername.TabIndex = 37;
            // 
            // botTokLabel
            // 
            this.botTokLabel.BackColor = System.Drawing.Color.Black;
            this.botTokLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.botTokLabel.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botTokLabel.ForeColor = System.Drawing.Color.White;
            this.botTokLabel.Location = new System.Drawing.Point(260, 261);
            this.botTokLabel.Name = "botTokLabel";
            this.botTokLabel.ReadOnly = true;
            this.botTokLabel.Size = new System.Drawing.Size(153, 29);
            this.botTokLabel.TabIndex = 40;
            this.botTokLabel.Text = "Bot Token:";
            // 
            // botToken
            // 
            this.botToken.BackColor = System.Drawing.Color.White;
            this.botToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.botToken.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botToken.Location = new System.Drawing.Point(446, 258);
            this.botToken.Name = "botToken";
            this.botToken.PasswordChar = '*';
            this.botToken.Size = new System.Drawing.Size(507, 34);
            this.botToken.TabIndex = 39;
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.BackColor = System.Drawing.Color.Black;
            this.clientIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientIdLabel.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIdLabel.ForeColor = System.Drawing.Color.White;
            this.clientIdLabel.Location = new System.Drawing.Point(260, 318);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.ReadOnly = true;
            this.clientIdLabel.Size = new System.Drawing.Size(153, 29);
            this.clientIdLabel.TabIndex = 42;
            this.clientIdLabel.Text = "Client Id:";
            // 
            // clientId
            // 
            this.clientId.BackColor = System.Drawing.Color.White;
            this.clientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientId.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientId.Location = new System.Drawing.Point(446, 313);
            this.clientId.Name = "clientId";
            this.clientId.PasswordChar = '*';
            this.clientId.Size = new System.Drawing.Size(507, 34);
            this.clientId.TabIndex = 41;
            // 
            // fps_limit
            // 
            this.fps_limit.BackColor = System.Drawing.Color.Black;
            this.fps_limit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fps_limit.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fps_limit.ForeColor = System.Drawing.Color.White;
            this.fps_limit.Location = new System.Drawing.Point(260, 373);
            this.fps_limit.Name = "fps_limit";
            this.fps_limit.ReadOnly = true;
            this.fps_limit.Size = new System.Drawing.Size(153, 29);
            this.fps_limit.TabIndex = 44;
            this.fps_limit.Text = "FPS Limit:";
            // 
            // fps_value
            // 
            this.fps_value.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.fps_value.FormattingEnabled = true;
            this.fps_value.ItemHeight = 33;
            this.fps_value.Items.AddRange(new object[] {
            "None",
            "30",
            "60"});
            this.fps_value.Location = new System.Drawing.Point(446, 367);
            this.fps_value.Name = "fps_value";
            this.fps_value.Size = new System.Drawing.Size(111, 41);
            this.fps_value.TabIndex = 45;
            // 
            // settings_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.fps_value);
            this.Controls.Add(this.fps_limit);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.botTokLabel);
            this.Controls.Add(this.botToken);
            this.Controls.Add(this.botUsrNmLabel);
            this.Controls.Add(this.botUsername);
            this.Controls.Add(this.chNmLabel);
            this.Controls.Add(this.channelName);
            this.Controls.Add(this.donTokenLabel);
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
        private System.Windows.Forms.TextBox donTokenLabel;
        private System.Windows.Forms.TextBox chNmLabel;
        public System.Windows.Forms.TextBox channelName;
        private System.Windows.Forms.TextBox botUsrNmLabel;
        public System.Windows.Forms.TextBox botUsername;
        private System.Windows.Forms.TextBox botTokLabel;
        public System.Windows.Forms.TextBox botToken;
        private System.Windows.Forms.TextBox clientIdLabel;
        public System.Windows.Forms.TextBox clientId;
        private System.Windows.Forms.TextBox fps_limit;
        public System.Windows.Forms.ComboBox fps_value;
    }
}

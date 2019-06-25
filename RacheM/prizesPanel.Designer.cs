namespace RacheM
{
    partial class prizesPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.prize = new System.Windows.Forms.Panel();
            this.hundredWinner = new System.Windows.Forms.TextBox();
            this.hundredOK = new System.Windows.Forms.Button();
            this.hundredBtn = new System.Windows.Forms.Button();
            this.cardBtn = new System.Windows.Forms.Button();
            this.roomBtn = new System.Windows.Forms.Button();
            this.nick = new AutoCompleteTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.completeBtn = new System.Windows.Forms.Button();
            this.players = new System.Windows.Forms.CheckedListBox();
            this.cardBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.prize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(110, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 123);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onPrize);
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
            this.home.TabIndex = 29;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // prize
            // 
            this.prize.BackgroundImage = global::RacheM.Properties.Resources.inventory1;
            this.prize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize.Controls.Add(this.hundredOK);
            this.prize.Controls.Add(this.hundredBtn);
            this.prize.Controls.Add(this.cardBtn);
            this.prize.Controls.Add(this.roomBtn);
            this.prize.Controls.Add(this.nick);
            this.prize.Controls.Add(this.addBtn);
            this.prize.Controls.Add(this.completeBtn);
            this.prize.Controls.Add(this.players);
            this.prize.Location = new System.Drawing.Point(465, 0);
            this.prize.Name = "prize";
            this.prize.Size = new System.Drawing.Size(350, 720);
            this.prize.TabIndex = 30;
            this.prize.Visible = false;
            // 
            // hundredWinner
            // 
            this.hundredWinner.Enabled = false;
            this.hundredWinner.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredWinner.Location = new System.Drawing.Point(433, 301);
            this.hundredWinner.Name = "hundredWinner";
            this.hundredWinner.Size = new System.Drawing.Size(414, 84);
            this.hundredWinner.TabIndex = 32;
            this.hundredWinner.Visible = false;
            // 
            // hundredOK
            // 
            this.hundredOK.BackColor = System.Drawing.Color.Black;
            this.hundredOK.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.hundredOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hundredOK.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredOK.ForeColor = System.Drawing.Color.Lime;
            this.hundredOK.Location = new System.Drawing.Point(108, 365);
            this.hundredOK.Name = "hundredOK";
            this.hundredOK.Size = new System.Drawing.Size(145, 38);
            this.hundredOK.TabIndex = 11;
            this.hundredOK.Text = "OK";
            this.hundredOK.UseVisualStyleBackColor = false;
            this.hundredOK.Visible = false;
            this.hundredOK.Click += new System.EventHandler(this.hundredOK_Click);
            // 
            // hundredBtn
            // 
            this.hundredBtn.BackColor = System.Drawing.Color.Black;
            this.hundredBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.hundredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hundredBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredBtn.ForeColor = System.Drawing.Color.Crimson;
            this.hundredBtn.Location = new System.Drawing.Point(185, 672);
            this.hundredBtn.Name = "hundredBtn";
            this.hundredBtn.Size = new System.Drawing.Size(145, 38);
            this.hundredBtn.TabIndex = 10;
            this.hundredBtn.Text = "Разыграть";
            this.hundredBtn.UseVisualStyleBackColor = false;
            this.hundredBtn.Visible = false;
            this.hundredBtn.Click += new System.EventHandler(this.hundredBtn_Click);
            // 
            // cardBtn
            // 
            this.cardBtn.BackColor = System.Drawing.Color.Black;
            this.cardBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.cardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardBtn.ForeColor = System.Drawing.Color.Blue;
            this.cardBtn.Location = new System.Drawing.Point(185, 628);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(145, 38);
            this.cardBtn.TabIndex = 9;
            this.cardBtn.Text = "Выполнить Карту";
            this.cardBtn.UseVisualStyleBackColor = false;
            this.cardBtn.Visible = false;
            this.cardBtn.Click += new System.EventHandler(this.cardBtn_Click);
            // 
            // roomBtn
            // 
            this.roomBtn.BackColor = System.Drawing.Color.Black;
            this.roomBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roomBtn.Location = new System.Drawing.Point(185, 672);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(145, 38);
            this.roomBtn.TabIndex = 8;
            this.roomBtn.Text = "Открыть Комнату";
            this.roomBtn.UseVisualStyleBackColor = false;
            this.roomBtn.Visible = false;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // nick
            // 
            this.nick.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nick.Location = new System.Drawing.Point(22, 676);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(145, 27);
            this.nick.TabIndex = 7;
            this.nick.TextChanged += new System.EventHandler(this.nick_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.addBtn.Location = new System.Drawing.Point(22, 628);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(145, 38);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // completeBtn
            // 
            this.completeBtn.BackColor = System.Drawing.Color.Black;
            this.completeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.completeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBtn.ForeColor = System.Drawing.Color.Lime;
            this.completeBtn.Location = new System.Drawing.Point(185, 628);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(145, 38);
            this.completeBtn.TabIndex = 5;
            this.completeBtn.Text = "Выполнить";
            this.completeBtn.UseVisualStyleBackColor = false;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // players
            // 
            this.players.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold);
            this.players.FormattingEnabled = true;
            this.players.Location = new System.Drawing.Point(22, 23);
            this.players.Name = "players";
            this.players.Size = new System.Drawing.Size(308, 599);
            this.players.TabIndex = 4;
            // 
            // cardBox
            // 
            this.cardBox.BackColor = System.Drawing.Color.Transparent;
            this.cardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardBox.Location = new System.Drawing.Point(830, 3);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(414, 656);
            this.cardBox.TabIndex = 31;
            this.cardBox.TabStop = false;
            this.cardBox.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(267, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 123);
            this.button2.TabIndex = 33;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.onPrize);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(422, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 123);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.onPrize);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(579, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 123);
            this.button4.TabIndex = 34;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.onPrize);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(735, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 123);
            this.button5.TabIndex = 38;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.onPrize);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(890, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 123);
            this.button6.TabIndex = 37;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.onPrize);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1047, 143);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 123);
            this.button7.TabIndex = 36;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.onPrize);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(110, 299);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 123);
            this.button8.TabIndex = 45;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.onPrize);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(267, 299);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 123);
            this.button9.TabIndex = 44;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.onPrize);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(422, 299);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 123);
            this.button10.TabIndex = 43;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.onPrize);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(579, 299);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(124, 123);
            this.button11.TabIndex = 42;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.onPrize);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(735, 299);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(124, 123);
            this.button12.TabIndex = 41;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.onPrize);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(890, 299);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(124, 123);
            this.button13.TabIndex = 40;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.onPrize);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(1047, 299);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(124, 123);
            this.button14.TabIndex = 39;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.onPrize);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(110, 455);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(124, 123);
            this.button15.TabIndex = 52;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.onPrize);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(267, 455);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(124, 123);
            this.button16.TabIndex = 51;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.onPrize);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(422, 455);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(124, 123);
            this.button17.TabIndex = 50;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.onPrize);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(579, 455);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(124, 123);
            this.button18.TabIndex = 49;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.onPrize);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(735, 455);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(124, 123);
            this.button19.TabIndex = 48;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.onPrize);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(890, 455);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(124, 123);
            this.button20.TabIndex = 47;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.onPrize);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(1047, 455);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(124, 123);
            this.button21.TabIndex = 46;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.onPrize);
            // 
            // prizesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RacheM.Properties.Resources.prizePanel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.hundredWinner);
            this.Controls.Add(this.prize);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.home);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "prizesPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Click += new System.EventHandler(this.prizesPanel_Click);
            this.prize.ResumeLayout(false);
            this.prize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel prize;
        private AutoCompleteTextBox nick;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button completeBtn;
        public System.Windows.Forms.CheckedListBox players;
        public System.Windows.Forms.Button roomBtn;
        public System.Windows.Forms.Button cardBtn;
        private System.Windows.Forms.PictureBox cardBox;
        public System.Windows.Forms.Button hundredBtn;
        public System.Windows.Forms.TextBox hundredWinner;
        public System.Windows.Forms.Button hundredOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
    }
}

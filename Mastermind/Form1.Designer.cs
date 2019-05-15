namespace Mastermind
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnNumber = new System.Windows.Forms.Button();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.nudThree = new System.Windows.Forms.NumericUpDown();
            this.nudTwo = new System.Windows.Forms.NumericUpDown();
            this.nudOne = new System.Windows.Forms.NumericUpDown();
            this.nudZero = new System.Windows.Forms.NumericUpDown();
            this.lbGame = new System.Windows.Forms.ListBox();
            this.btnguess = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.gbPlayer.SuspendLayout();
            this.gbDifficulty.SuspendLayout();
            this.gbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZero)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.btnPlayer);
            this.gbPlayer.Controls.Add(this.tbName);
            this.gbPlayer.Controls.Add(this.lblName);
            this.gbPlayer.Location = new System.Drawing.Point(16, 143);
            this.gbPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPlayer.Size = new System.Drawing.Size(288, 111);
            this.gbPlayer.TabIndex = 0;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "playerInfo";
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(12, 68);
            this.btnPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(247, 28);
            this.btnPlayer.TabIndex = 1;
            this.btnPlayer.Text = "Create player";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(63, 32);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(128, 22);
            this.tbName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(16, 258);
            this.lbPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(287, 132);
            this.lbPlayers.TabIndex = 1;
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.cbDifficulty);
            this.gbDifficulty.Controls.Add(this.btnStop);
            this.gbDifficulty.Controls.Add(this.lblNumber);
            this.gbDifficulty.Controls.Add(this.btnNumber);
            this.gbDifficulty.Enabled = false;
            this.gbDifficulty.Location = new System.Drawing.Point(16, 25);
            this.gbDifficulty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDifficulty.Size = new System.Drawing.Size(288, 111);
            this.gbDifficulty.TabIndex = 2;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Difficulty";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy, \t    8 attemps",
            "Normal, \t    7 attempts",
            "Hard, \t    5 attempts",
            "Impossible, 4 attempts"});
            this.cbDifficulty.Location = new System.Drawing.Point(8, 37);
            this.cbDifficulty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(271, 24);
            this.cbDifficulty.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(145, 70);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 28);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(16, 18);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(84, 17);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Set difficulty";
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(8, 70);
            this.btnNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(129, 28);
            this.btnNumber.TabIndex = 1;
            this.btnNumber.Text = "Create Number";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.lblAttempts);
            this.gbGame.Controls.Add(this.lblOne);
            this.gbGame.Controls.Add(this.nudThree);
            this.gbGame.Controls.Add(this.nudTwo);
            this.gbGame.Controls.Add(this.nudOne);
            this.gbGame.Controls.Add(this.nudZero);
            this.gbGame.Controls.Add(this.lbGame);
            this.gbGame.Controls.Add(this.btnguess);
            this.gbGame.Enabled = false;
            this.gbGame.Location = new System.Drawing.Point(320, 25);
            this.gbGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGame.Name = "gbGame";
            this.gbGame.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGame.Size = new System.Drawing.Size(453, 369);
            this.gbGame.TabIndex = 3;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "gbGame";
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(357, 60);
            this.lblAttempts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(0, 17);
            this.lblAttempts.TabIndex = 5;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(232, 60);
            this.lblOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(116, 17);
            this.lblOne.TabIndex = 4;
            this.lblOne.Text = "Aantal Pogingen:";
            // 
            // nudThree
            // 
            this.nudThree.Location = new System.Drawing.Point(176, 23);
            this.nudThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudThree.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudThree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThree.Name = "nudThree";
            this.nudThree.Size = new System.Drawing.Size(48, 22);
            this.nudThree.TabIndex = 5;
            this.nudThree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTwo
            // 
            this.nudTwo.Location = new System.Drawing.Point(120, 23);
            this.nudTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudTwo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudTwo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTwo.Name = "nudTwo";
            this.nudTwo.Size = new System.Drawing.Size(48, 22);
            this.nudTwo.TabIndex = 4;
            this.nudTwo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudOne
            // 
            this.nudOne.Location = new System.Drawing.Point(64, 23);
            this.nudOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudOne.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudOne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOne.Name = "nudOne";
            this.nudOne.Size = new System.Drawing.Size(48, 22);
            this.nudOne.TabIndex = 3;
            this.nudOne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudZero
            // 
            this.nudZero.Location = new System.Drawing.Point(8, 23);
            this.nudZero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudZero.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudZero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudZero.Name = "nudZero";
            this.nudZero.Size = new System.Drawing.Size(48, 22);
            this.nudZero.TabIndex = 2;
            this.nudZero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbGame
            // 
            this.lbGame.FormattingEnabled = true;
            this.lbGame.ItemHeight = 16;
            this.lbGame.Location = new System.Drawing.Point(8, 90);
            this.lbGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(436, 276);
            this.lbGame.TabIndex = 1;
            // 
            // btnguess
            // 
            this.btnguess.Location = new System.Drawing.Point(8, 54);
            this.btnguess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(216, 28);
            this.btnguess.TabIndex = 0;
            this.btnguess.Text = "btnGuess";
            this.btnguess.UseVisualStyleBackColor = true;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(789, 409);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbDifficulty);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.gbPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbDifficulty.ResumeLayout(false);
            this.gbDifficulty.PerformLayout();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.ListBox lbGame;
        private System.Windows.Forms.NumericUpDown nudThree;
        private System.Windows.Forms.NumericUpDown nudTwo;
        private System.Windows.Forms.NumericUpDown nudOne;
        private System.Windows.Forms.NumericUpDown nudZero;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Timer Timer;
    }
}


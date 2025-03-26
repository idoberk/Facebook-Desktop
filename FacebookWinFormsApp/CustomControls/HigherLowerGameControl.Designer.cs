namespace BasicFacebookFeatures.CustomControls
{
    partial class HigherLowerGameControl
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
            if(disposing && (components != null))
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTimeOver = new System.Windows.Forms.Label();
            this.panelPage1 = new System.Windows.Forms.Panel();
            this.pictureBoxPage1 = new System.Windows.Forms.PictureBox();
            this.labelPage1Name = new System.Windows.Forms.Label();
            this.labelPage1Likes = new System.Windows.Forms.Label();
            this.panelPage2 = new System.Windows.Forms.Panel();
            this.pictureBoxPage2 = new System.Windows.Forms.PictureBox();
            this.labelPage2Name = new System.Windows.Forms.Label();
            this.labelPage2Likes = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonHigherPage1 = new BasicFacebookFeatures.CustomControls.RoundedButton();
            this.buttonHigherPage2 = new BasicFacebookFeatures.CustomControls.RoundedButton();
            this.buttonNewGame = new BasicFacebookFeatures.CustomControls.RoundedButton();
            this.panelMain.SuspendLayout();
            this.panelPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage1)).BeginInit();
            this.panelPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMain.Controls.Add(this.labelTimeOver);
            this.panelMain.Controls.Add(this.panelPage1);
            this.panelMain.Controls.Add(this.panelPage2);
            this.panelMain.Controls.Add(this.labelTimer);
            this.panelMain.Controls.Add(this.labelScore);
            this.panelMain.Controls.Add(this.buttonNewGame);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(560, 350);
            this.panelMain.TabIndex = 0;
            // 
            // labelTimeOver
            // 
            this.labelTimeOver.BackColor = System.Drawing.Color.Red;
            this.labelTimeOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOver.ForeColor = System.Drawing.Color.White;
            this.labelTimeOver.Location = new System.Drawing.Point(215, 175);
            this.labelTimeOver.Name = "labelTimeOver";
            this.labelTimeOver.Size = new System.Drawing.Size(130, 50);
            this.labelTimeOver.TabIndex = 1;
            this.labelTimeOver.Text = "TIME OVER!";
            this.labelTimeOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPage1
            // 
            this.panelPage1.BackColor = System.Drawing.SystemColors.Control;
            this.panelPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPage1.Controls.Add(this.pictureBoxPage1);
            this.panelPage1.Controls.Add(this.labelPage1Name);
            this.panelPage1.Controls.Add(this.buttonHigherPage1);
            this.panelPage1.Controls.Add(this.labelPage1Likes);
            this.panelPage1.Location = new System.Drawing.Point(20, 83);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(250, 250);
            this.panelPage1.TabIndex = 6;
            // 
            // pictureBoxPage1
            // 
            this.pictureBoxPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPage1.BackColor = System.Drawing.Color.White;
            this.pictureBoxPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage1.Location = new System.Drawing.Point(65, 45);
            this.pictureBoxPage1.Name = "pictureBoxPage1";
            this.pictureBoxPage1.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxPage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage1.TabIndex = 9;
            this.pictureBoxPage1.TabStop = false;
            // 
            // labelPage1Name
            // 
            this.labelPage1Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage1Name.AutoEllipsis = true;
            this.labelPage1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage1Name.Location = new System.Drawing.Point(3, 10);
            this.labelPage1Name.Name = "labelPage1Name";
            this.labelPage1Name.Size = new System.Drawing.Size(242, 23);
            this.labelPage1Name.TabIndex = 8;
            this.labelPage1Name.Text = "Page Name";
            this.labelPage1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPage1Likes
            // 
            this.labelPage1Likes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage1Likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage1Likes.Location = new System.Drawing.Point(3, 171);
            this.labelPage1Likes.Name = "labelPage1Likes";
            this.labelPage1Likes.Size = new System.Drawing.Size(242, 23);
            this.labelPage1Likes.TabIndex = 6;
            this.labelPage1Likes.Text = "1,000,000 likes";
            this.labelPage1Likes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPage2
            // 
            this.panelPage2.BackColor = System.Drawing.SystemColors.Control;
            this.panelPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPage2.Controls.Add(this.pictureBoxPage2);
            this.panelPage2.Controls.Add(this.labelPage2Name);
            this.panelPage2.Controls.Add(this.buttonHigherPage2);
            this.panelPage2.Controls.Add(this.labelPage2Likes);
            this.panelPage2.Location = new System.Drawing.Point(290, 83);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(250, 250);
            this.panelPage2.TabIndex = 5;
            // 
            // pictureBoxPage2
            // 
            this.pictureBoxPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPage2.BackColor = System.Drawing.Color.White;
            this.pictureBoxPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage2.Location = new System.Drawing.Point(65, 45);
            this.pictureBoxPage2.Name = "pictureBoxPage2";
            this.pictureBoxPage2.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxPage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage2.TabIndex = 9;
            this.pictureBoxPage2.TabStop = false;
            // 
            // labelPage2Name
            // 
            this.labelPage2Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage2Name.AutoEllipsis = true;
            this.labelPage2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage2Name.Location = new System.Drawing.Point(3, 10);
            this.labelPage2Name.Name = "labelPage2Name";
            this.labelPage2Name.Size = new System.Drawing.Size(242, 23);
            this.labelPage2Name.TabIndex = 8;
            this.labelPage2Name.Text = "Page Name";
            this.labelPage2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPage2Likes
            // 
            this.labelPage2Likes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage2Likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage2Likes.Location = new System.Drawing.Point(3, 171);
            this.labelPage2Likes.Name = "labelPage2Likes";
            this.labelPage2Likes.Size = new System.Drawing.Size(242, 23);
            this.labelPage2Likes.TabIndex = 6;
            this.labelPage2Likes.Text = "1,000,000 likes";
            this.labelPage2Likes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(235, 46);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(86, 20);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Time: 15s";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(12, 18);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(76, 20);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHigherPage1
            // 
            this.buttonHigherPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHigherPage1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonHigherPage1.BorderColor = System.Drawing.Color.PaleGreen;
            this.buttonHigherPage1.BorderRadius = 40;
            this.buttonHigherPage1.BorderSize = 0;
            this.buttonHigherPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHigherPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHigherPage1.ForeColor = System.Drawing.Color.White;
            this.buttonHigherPage1.Location = new System.Drawing.Point(45, 200);
            this.buttonHigherPage1.Name = "buttonHigherPage1";
            this.buttonHigherPage1.Size = new System.Drawing.Size(160, 40);
            this.buttonHigherPage1.TabIndex = 7;
            this.buttonHigherPage1.Text = "Higher";
            this.buttonHigherPage1.TextColor = System.Drawing.Color.White;
            this.buttonHigherPage1.UseVisualStyleBackColor = false;
            this.buttonHigherPage1.Click += new System.EventHandler(this.buttonHigherPage1_Click);
            // 
            // buttonHigherPage2
            // 
            this.buttonHigherPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHigherPage2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonHigherPage2.BorderColor = System.Drawing.Color.PaleGreen;
            this.buttonHigherPage2.BorderRadius = 40;
            this.buttonHigherPage2.BorderSize = 0;
            this.buttonHigherPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHigherPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHigherPage2.ForeColor = System.Drawing.Color.White;
            this.buttonHigherPage2.Location = new System.Drawing.Point(45, 200);
            this.buttonHigherPage2.Name = "buttonHigherPage2";
            this.buttonHigherPage2.Size = new System.Drawing.Size(160, 40);
            this.buttonHigherPage2.TabIndex = 7;
            this.buttonHigherPage2.Text = "Higher";
            this.buttonHigherPage2.TextColor = System.Drawing.Color.White;
            this.buttonHigherPage2.UseVisualStyleBackColor = false;
            this.buttonHigherPage2.Click += new System.EventHandler(this.buttonHigherPage2_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNewGame.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonNewGame.BorderColor = System.Drawing.Color.PaleGreen;
            this.buttonNewGame.BorderRadius = 33;
            this.buttonNewGame.BorderSize = 0;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.Location = new System.Drawing.Point(440, 13);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(100, 33);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.TextColor = System.Drawing.Color.White;
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // HigherLowerGameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "HigherLowerGameControl";
            this.Size = new System.Drawing.Size(560, 350);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage1)).EndInit();
            this.panelPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private RoundedButton buttonNewGame;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTimeOver;
        private System.Windows.Forms.Panel panelPage2;
        private RoundedButton buttonHigherPage2;
        private System.Windows.Forms.Label labelPage2Likes;
        private System.Windows.Forms.PictureBox pictureBoxPage2;
        private System.Windows.Forms.Label labelPage2Name;
        private System.Windows.Forms.Panel panelPage1;
        private System.Windows.Forms.PictureBox pictureBoxPage1;
        private System.Windows.Forms.Label labelPage1Name;
        private RoundedButton buttonHigherPage1;
        private System.Windows.Forms.Label labelPage1Likes;
    }
}

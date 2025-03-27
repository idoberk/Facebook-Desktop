using System.Drawing;
using BasicFacebookFeatures.CustomControls;

namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new BasicFacebookFeatures.CustomControls.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.profilePictureBox = new BasicFacebookFeatures.CustomControls.CircularPictureBox();
            this.buttonLogout = new BasicFacebookFeatures.CustomControls.RoundedButton();
            this.labelUserName = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPageHigherLower = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonNewGame = new BasicFacebookFeatures.CustomControls.RoundedButton();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelTimeOver = new System.Windows.Forms.Label();
            this.panelPage1 = new System.Windows.Forms.Panel();
            this.pictureBoxPage1 = new System.Windows.Forms.PictureBox();
            this.labelPage1Name = new System.Windows.Forms.Label();
            this.buttonHigherPage1 = new BasicFacebookFeatures.CustomControls.RoundedButton();
            this.labelPage1Likes = new System.Windows.Forms.Label();
            this.panelPage2 = new System.Windows.Forms.Panel();
            this.pictureBoxPage2 = new System.Windows.Forms.PictureBox();
            this.labelPage2Name = new System.Windows.Forms.Label();
            this.buttonHigherPage2 = new BasicFacebookFeatures.CustomControls.RoundedButton();
            this.labelPage2Likes = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.tabPageHigherLower.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage1)).BeginInit();
            this.panelPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "profile_icon.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageHigherLower);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 27);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(850, 557);
            this.tabControl1.TabIndex = 54;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.profilePictureBox);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.labelUserName);
            this.tabPage1.Controls.Add(this.coverPictureBox);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(842, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.ToolTipText = "Profile Page";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profilePictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profilePictureBox.BorderSize = 5;
            this.profilePictureBox.FirstBorderColor = System.Drawing.Color.DodgerBlue;
            this.profilePictureBox.GradientAngle = 270F;
            this.profilePictureBox.Location = new System.Drawing.Point(286, 169);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.SecondBorderColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Size = new System.Drawing.Size(150, 150);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 63;
            this.profilePictureBox.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.BackColor = System.Drawing.Color.Red;
            this.buttonLogout.BackgroundColor = System.Drawing.Color.Red;
            this.buttonLogout.BorderColor = System.Drawing.Color.Empty;
            this.buttonLogout.BorderRadius = 25;
            this.buttonLogout.BorderSize = 0;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(8, 474);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(177, 40);
            this.buttonLogout.TabIndex = 62;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextColor = System.Drawing.Color.White;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 18F);
            this.labelUserName.Location = new System.Drawing.Point(442, 241);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(184, 27);
            this.labelUserName.TabIndex = 59;
            this.labelUserName.Text = "User name here";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.coverPictureBox.Location = new System.Drawing.Point(0, 0);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(842, 226);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coverPictureBox.TabIndex = 57;
            this.coverPictureBox.TabStop = false;
            // 
            // tabPageHigherLower
            // 
            this.tabPageHigherLower.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageHigherLower.Controls.Add(this.panelMain);
            this.tabPageHigherLower.Location = new System.Drawing.Point(4, 31);
            this.tabPageHigherLower.Name = "tabPageHigherLower";
            this.tabPageHigherLower.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHigherLower.Size = new System.Drawing.Size(842, 522);
            this.tabPageHigherLower.TabIndex = 1;
            this.tabPageHigherLower.ToolTipText = "HigherLower";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMain.Controls.Add(this.labelTimeOver);
            this.panelMain.Controls.Add(this.panelPage2);
            this.panelMain.Controls.Add(this.panelPage1);
            this.panelMain.Controls.Add(this.labelTimer);
            this.panelMain.Controls.Add(this.buttonNewGame);
            this.panelMain.Controls.Add(this.labelScore);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(836, 516);
            this.panelMain.TabIndex = 0;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(20, 26);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(76, 20);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNewGame.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonNewGame.BorderColor = System.Drawing.Color.PaleGreen;
            this.buttonNewGame.BorderRadius = 30;
            this.buttonNewGame.BorderSize = 0;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.Location = new System.Drawing.Point(682, 10);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(130, 46);
            this.buttonNewGame.TabIndex = 5;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.TextColor = System.Drawing.Color.White;
            this.buttonNewGame.UseVisualStyleBackColor = false;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(375, 67);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(86, 20);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Time: 15s";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeOver
            // 
            this.labelTimeOver.BackColor = System.Drawing.Color.Red;
            this.labelTimeOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOver.ForeColor = System.Drawing.Color.White;
            this.labelTimeOver.Location = new System.Drawing.Point(353, 231);
            this.labelTimeOver.Name = "labelTimeOver";
            this.labelTimeOver.Size = new System.Drawing.Size(130, 50);
            this.labelTimeOver.TabIndex = 7;
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
            this.panelPage1.Location = new System.Drawing.Point(24, 100);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(340, 340);
            this.panelPage1.TabIndex = 8;
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
            this.pictureBoxPage1.Size = new System.Drawing.Size(210, 210);
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
            this.labelPage1Name.Size = new System.Drawing.Size(332, 23);
            this.labelPage1Name.TabIndex = 8;
            this.labelPage1Name.Text = "Page Name";
            this.labelPage1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonHigherPage1.Location = new System.Drawing.Point(90, 290);
            this.buttonHigherPage1.Name = "buttonHigherPage1";
            this.buttonHigherPage1.Size = new System.Drawing.Size(160, 40);
            this.buttonHigherPage1.TabIndex = 7;
            this.buttonHigherPage1.Text = "Higher";
            this.buttonHigherPage1.TextColor = System.Drawing.Color.White;
            this.buttonHigherPage1.UseVisualStyleBackColor = false;
            // 
            // labelPage1Likes
            // 
            this.labelPage1Likes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage1Likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage1Likes.Location = new System.Drawing.Point(3, 261);
            this.labelPage1Likes.Name = "labelPage1Likes";
            this.labelPage1Likes.Size = new System.Drawing.Size(332, 23);
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
            this.panelPage2.Location = new System.Drawing.Point(472, 100);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(340, 340);
            this.panelPage2.TabIndex = 9;
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
            this.pictureBoxPage2.Size = new System.Drawing.Size(210, 210);
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
            this.labelPage2Name.Size = new System.Drawing.Size(332, 23);
            this.labelPage2Name.TabIndex = 8;
            this.labelPage2Name.Text = "Page Name";
            this.labelPage2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonHigherPage2.Location = new System.Drawing.Point(90, 290);
            this.buttonHigherPage2.Name = "buttonHigherPage2";
            this.buttonHigherPage2.Size = new System.Drawing.Size(160, 40);
            this.buttonHigherPage2.TabIndex = 7;
            this.buttonHigherPage2.Text = "Higher";
            this.buttonHigherPage2.TextColor = System.Drawing.Color.White;
            this.buttonHigherPage2.UseVisualStyleBackColor = false;
            // 
            // labelPage2Likes
            // 
            this.labelPage2Likes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage2Likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage2Likes.Location = new System.Drawing.Point(3, 261);
            this.labelPage2Likes.Name = "labelPage2Likes";
            this.labelPage2Likes.Size = new System.Drawing.Size(332, 23);
            this.labelPage2Likes.TabIndex = 6;
            this.labelPage2Likes.Text = "1,000,000 likes";
            this.labelPage2Likes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 557);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook DP Course";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.tabPageHigherLower.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage1)).EndInit();
            this.panelPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage2)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
		private CustomTabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPageHigherLower;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelUserName;
        private RoundedButton buttonLogout;
        private CircularPictureBox profilePictureBox;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelScore;
        private RoundedButton buttonNewGame;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelTimeOver;
        private System.Windows.Forms.Panel panelPage2;
        private System.Windows.Forms.PictureBox pictureBoxPage2;
        private System.Windows.Forms.Label labelPage2Name;
        private RoundedButton buttonHigherPage2;
        private System.Windows.Forms.Label labelPage2Likes;
        private System.Windows.Forms.Panel panelPage1;
        private System.Windows.Forms.PictureBox pictureBoxPage1;
        private System.Windows.Forms.Label labelPage1Name;
        private RoundedButton buttonHigherPage1;
        private System.Windows.Forms.Label labelPage1Likes;
    }
}


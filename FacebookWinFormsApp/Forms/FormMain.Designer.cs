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
            this.labelUserName = new System.Windows.Forms.Label();
            this.profilePictureBox = new BasicFacebookFeatures.CustomControls.CircularPictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxPage2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage1 = new System.Windows.Forms.PictureBox();
            this.labelPage2 = new System.Windows.Forms.Label();
            this.labelPage1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage1)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 27);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(801, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.profilePictureBox);
            this.tabPage1.Controls.Add(this.labelUserName);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.ToolTipText = "Profile Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 18F);
            this.labelUserName.Location = new System.Drawing.Point(471, 289);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(184, 27);
            this.labelUserName.TabIndex = 59;
            this.labelUserName.Text = "User name here";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUserName.Visible = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profilePictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profilePictureBox.BorderSize = 7;
            this.profilePictureBox.FirstBorderColor = System.Drawing.Color.SandyBrown;
            this.profilePictureBox.GradientAngle = 20F;
            this.profilePictureBox.Location = new System.Drawing.Point(315, 232);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.SecondBorderColor = System.Drawing.Color.DodgerBlue;
            this.profilePictureBox.Size = new System.Drawing.Size(150, 150);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 58;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Visible = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(228, 581);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.ReadOnly = true;
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "668236632596331";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 536);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 36);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\". The grader will use it to test yo" +
    "ur app.\r\nType here your own AppID to test it:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.Enabled = false;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogout.Location = new System.Drawing.Point(18, 621);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.MinimumSize = new System.Drawing.Size(268, 32);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 489);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBoxPage2);
            this.tabPage2.Controls.Add(this.pictureBoxPage1);
            this.tabPage2.Controls.Add(this.labelPage2);
            this.tabPage2.Controls.Add(this.labelPage1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.ToolTipText = "HigherLower";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPage2
            // 
            this.pictureBoxPage2.Location = new System.Drawing.Point(340, 137);
            this.pictureBoxPage2.Name = "pictureBoxPage2";
            this.pictureBoxPage2.Size = new System.Drawing.Size(203, 179);
            this.pictureBoxPage2.TabIndex = 3;
            this.pictureBoxPage2.TabStop = false;
            // 
            // pictureBoxPage1
            // 
            this.pictureBoxPage1.Location = new System.Drawing.Point(57, 137);
            this.pictureBoxPage1.Name = "pictureBoxPage1";
            this.pictureBoxPage1.Size = new System.Drawing.Size(203, 179);
            this.pictureBoxPage1.TabIndex = 2;
            this.pictureBoxPage1.TabStop = false;
            // 
            // labelPage2
            // 
            this.labelPage2.AutoSize = true;
            this.labelPage2.Location = new System.Drawing.Point(337, 103);
            this.labelPage2.Name = "labelPage2";
            this.labelPage2.Size = new System.Drawing.Size(56, 18);
            this.labelPage2.TabIndex = 1;
            this.labelPage2.Text = "Page B";
            // 
            // labelPage1
            // 
            this.labelPage1.AutoSize = true;
            this.labelPage1.Location = new System.Drawing.Point(54, 103);
            this.labelPage1.Name = "labelPage1";
            this.labelPage1.Size = new System.Drawing.Size(55, 18);
            this.labelPage1.TabIndex = 0;
            this.labelPage1.Text = "Page A";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(801, 697);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage1)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private CustomTabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularPictureBox profilePictureBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxPage2;
        private System.Windows.Forms.PictureBox pictureBoxPage1;
        private System.Windows.Forms.Label labelPage2;
        private System.Windows.Forms.Label labelPage1;
        private System.Windows.Forms.Label labelUserName;
    }
}


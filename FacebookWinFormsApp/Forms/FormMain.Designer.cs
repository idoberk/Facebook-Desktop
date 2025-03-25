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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.higherLowerGameControl1 = new BasicFacebookFeatures.CustomControls.HigherLowerGameControl();
            this.pictureBoxPage2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage1 = new System.Windows.Forms.PictureBox();
            this.labelPage2 = new System.Windows.Forms.Label();
            this.labelPage1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(850, 557);
            this.tabControl1.TabIndex = 54;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.higherLowerGameControl1);
            this.tabPage2.Controls.Add(this.pictureBoxPage2);
            this.tabPage2.Controls.Add(this.pictureBoxPage1);
            this.tabPage2.Controls.Add(this.labelPage2);
            this.tabPage2.Controls.Add(this.labelPage1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.ToolTipText = "HigherLower";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // higherLowerGameControl1
            // 
            this.higherLowerGameControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.higherLowerGameControl1.Location = new System.Drawing.Point(3, 3);
            this.higherLowerGameControl1.Margin = new System.Windows.Forms.Padding(4);
            this.higherLowerGameControl1.Name = "higherLowerGameControl1";
            this.higherLowerGameControl1.Size = new System.Drawing.Size(836, 516);
            this.higherLowerGameControl1.TabIndex = 4;
            // 
            // pictureBoxPage2
            // 
            this.pictureBoxPage2.Location = new System.Drawing.Point(340, 137);
            this.pictureBoxPage2.Name = "pictureBoxPage2";
            this.pictureBoxPage2.Size = new System.Drawing.Size(203, 179);
            this.pictureBoxPage2.TabIndex = 3;
            this.pictureBoxPage2.TabStop = false;
            this.pictureBoxPage2.Visible = false;
            // 
            // pictureBoxPage1
            // 
            this.pictureBoxPage1.Location = new System.Drawing.Point(57, 137);
            this.pictureBoxPage1.Name = "pictureBoxPage1";
            this.pictureBoxPage1.Size = new System.Drawing.Size(203, 179);
            this.pictureBoxPage1.TabIndex = 2;
            this.pictureBoxPage1.TabStop = false;
            this.pictureBoxPage1.Visible = false;
            // 
            // labelPage2
            // 
            this.labelPage2.AutoSize = true;
            this.labelPage2.Location = new System.Drawing.Point(337, 103);
            this.labelPage2.Name = "labelPage2";
            this.labelPage2.Size = new System.Drawing.Size(56, 18);
            this.labelPage2.TabIndex = 1;
            this.labelPage2.Text = "Page B";
            this.labelPage2.Visible = false;
            // 
            // labelPage1
            // 
            this.labelPage1.AutoSize = true;
            this.labelPage1.Location = new System.Drawing.Point(54, 103);
            this.labelPage1.Name = "labelPage1";
            this.labelPage1.Size = new System.Drawing.Size(55, 18);
            this.labelPage1.TabIndex = 0;
            this.labelPage1.Text = "Page A";
            this.labelPage1.Visible = false;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage1)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
		private CustomTabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxPage2;
        private System.Windows.Forms.PictureBox pictureBoxPage1;
        private System.Windows.Forms.Label labelPage2;
        private System.Windows.Forms.Label labelPage1;
        private System.Windows.Forms.Label labelUserName;
        private RoundedButton buttonLogout;
        private HigherLowerGameControl higherLowerGameControl1;
        private CircularPictureBox profilePictureBox;
    }
}


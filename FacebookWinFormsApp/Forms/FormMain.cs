using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private LoginResult m_LoginResult;
        private static readonly string[] sr_AppPermissions = { "public_profile", "email", "user_friends", "user_birthday", "user_posts" };


        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            //if (m_LoginResult == null)
            //{
            //    login();
            //}
            login();
        }

        private void login()
        {
            try
            {
                m_LoginResult = FacebookWrapper.FacebookService.Connect(
                    "EAAJfwfccn2sBOwN1OE1Gd3ueaWecQlZB59itvBmWVkTLYI79CEZBZAp9lq6xaAx7IVt1ZCgz2dp6ZAPb8EA0W3514f0WFu083uNKOSt40una1EqwAFw1dRw3NpYORo68UWoRMgZBQ7aWHI0Us9QeZAT0kLzElumZBFLXsUWCjg2O9s4OE3vBVlbrUL19nUtnKYvZBzZAuBFVTJejpqA2p55iObHDGk21q4");
                // m_LoginResult = FacebookService.Login(textBoxAppID.Text, sr_AppPermissions);

                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    new Thread(getUserInfo).Start();
                    //buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    labelUserName.Text = m_LoginResult.LoggedInUser.Name;
                    labelUserName.Visible = true;
                    buttonLogin.BackColor = Color.LightGreen;
                    profilePictureBox.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                    profilePictureBox.Visible = true;
                    buttonLogin.Enabled = false;
                    buttonLogout.Enabled = true;
                    buttonLogout.BackColor = Color.Red;
                    pictureBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage);
                }
            }
            catch
            {
                MessageBox.Show("Login failed");
                this.Close();
            }
        }

        private void getUserInfo()
        {
            getCoverPhoto();
            getPage();
        }


        private void getCoverPhoto()
        {
            string coverPhotoURL = string.Empty;

            foreach (Album photoAlbum in m_LoginResult.LoggedInUser.Albums)
            {
                if (photoAlbum.Name == "Cover photos")
                {
                    coverPhotoURL = photoAlbum.Photos[0].PictureNormalURL;
                }
            }

            pictureBox1.ImageLocation = coverPhotoURL;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout();
            //FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogout.BackColor = Color.Transparent;
            buttonLogin.BackColor = buttonLogout.BackColor;
            profilePictureBox.ImageLocation = null;
            pictureBox1.ImageLocation = null;
            profilePictureBox.Visible = false;
            m_LoginResult = null;
            labelUserName.Text = String.Empty;
            labelUserName.Visible = false;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            pictureBox1.Visible = false;
        }

        private void getPage()
        {
            labelPage1.Text = m_LoginResult.LoggedInUser.LikedPages[0].Name;
            labelPage2.Text = m_LoginResult.LoggedInUser.LikedPages[1].Name;
            pictureBoxPage1.ImageLocation = m_LoginResult.LoggedInUser.LikedPages[0].PictureURL;
            pictureBoxPage2.ImageLocation = m_LoginResult.LoggedInUser.LikedPages[1].PictureURL;
        }
    }
}
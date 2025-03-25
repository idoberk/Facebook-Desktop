using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            new Thread(getUserInfo).Start();
        }

        private void getUserInfo()
        {
            labelUserName.Text = m_LoggedInUser.Name;
            getCoverPhoto();
            getProfilePhoto();
            // getUserName();
            getPage();
        }

        private void getUserName()
        {
            labelUserName.Text = m_LoggedInUser.Name;
        }

        private void getProfilePhoto()
        {
            profilePictureBox.ImageLocation = m_LoggedInUser.PictureNormalURL;
        }


        private void getCoverPhoto()
        {
            string coverPhotoURL = string.Empty;

            foreach (Album photoAlbum in m_LoggedInUser.Albums)
            {
                if (photoAlbum.Name == "Cover photos")
                {
                    coverPhotoURL = photoAlbum.Photos[0].PictureNormalURL;
                }
            }

            coverPictureBox.ImageLocation = coverPhotoURL;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout();
            this.Invoke(new Action(this.Close));
        }

        private void getPage()
        {
            labelPage1.Text = m_LoggedInUser.LikedPages[0].Name;
            labelPage2.Text = m_LoggedInUser.LikedPages[1].Name;
            pictureBoxPage1.ImageLocation = m_LoggedInUser.LikedPages[0].PictureURL;
            pictureBoxPage2.ImageLocation = m_LoggedInUser.LikedPages[1].PictureURL;
        }
    }
}
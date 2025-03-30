using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Backend;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

// TODO: Use AppSettings to save some data if the user wants.
// TODO: Save High Score to the xml file if the score the user got is higher than the current high score.
// TODO: Go over the code of the game and see if it can be cleaned up.

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private HigherLowerGameManager m_GameManager;

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            FormClosing += FormMain_FormClosing;
            new Thread(getUserInfo).Start();
        }

        private void getUserInfo()
        {
            labelUserName.Text = m_LoggedInUser.Name;
            getCoverPhoto();
            getProfilePhoto();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageHigherLower)
            {
                if (m_GameManager == null)
                {
                    m_GameManager = new HigherLowerGameManager(
                        labelScore,
                        labelTimer,
                        labelRoundFeedback,
                        labelPage1Name,
                        labelPage2Name,
                        labelPage1Likes,
                        labelPage2Likes,
                        pictureBoxPage1,
                        pictureBoxPage2,
                        buttonHigherPage1,
                        buttonHigherPage2,
                        buttonNewGame,
                        this,
                        m_LoggedInUser);
                }

                m_GameManager.Initialize();
            }
            else
            {
                m_GameManager.Cleanup();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_GameManager != null)
            {
                m_GameManager.Cleanup();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Backend;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Message = FacebookWrapper.ObjectModel.Message;

// TODO: Remember to change to login and logout methods before submitting the project.
// TODO: Use AppSettings to save some data if the user wants.
// TODO: Save High Score to the xml file if the score the user got is higher than the current high score.
// TODO: Go over the code of the game and see if it can be cleaned up.
// TODO: Add confirmation to end the game if the user wants to leave the game page (whether if by closing the form or moving to a different tab).

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private HigherLowerGameManager m_GameManager;
        private UserDataManager m_UserDataManager;
        private bool m_IsLoggingOut = false;

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;

            initUserDataManager();
            // new Thread(getUserInfo).Start();
            //getUserInfo();
        }

        private void initUserDataManager()
        {
            m_UserDataManager = new UserDataManager(m_LoggedInUser);
        }

        private void getUserInfo()
        {
            labelUserName.Text = m_LoggedInUser.Name;
            profilePictureBox.ImageLocation = m_UserDataManager.UserProfilePicURL;
            coverPictureBox.ImageLocation = m_UserDataManager.UserCoverPicURL;

            foreach (string userInfo in m_UserDataManager.UserInfo)
            {
                //listBoxUserInfo.Invoke(new Action(() => listBoxUserInfo.Items.Add(userInfo)));
                listBoxUserInfo.Items.Add(userInfo);
            }
            //getCoverPhoto();
            //getProfilePhoto();
        }

        //private void getProfilePhoto()
        //{
        //    profilePictureBox.ImageLocation = m_LoggedInUser.PictureNormalURL;
        //}

        //private void getCoverPhoto()
        //{
        //    string coverPhotoURL = string.Empty;

        //    foreach (Album photoAlbum in m_LoggedInUser.Albums)
        //    {
        //        if (photoAlbum.Name == "Cover photos")
        //        {
        //            coverPhotoURL = photoAlbum.Photos[0].PictureNormalURL;
        //        }
        //    }

        //    coverPictureBox.ImageLocation = coverPhotoURL;
        //}

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_IsLoggingOut = true;
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            Thread dataLoadingThread = new Thread(loadUserDataInBackground);

            dataLoadingThread.IsBackground = true;
            dataLoadingThread.Start();
        }

        private void loadUserDataInBackground()
        {
            try
            {
                string name = m_LoggedInUser.Name;
                string profilePicUrl = m_UserDataManager.UserProfilePicURL;
                string coverPicUrl = m_UserDataManager.UserCoverPicURL;
                List<string> UserInfoItems = new List<string>();

                foreach (string info in m_UserDataManager.UserInfo)
                {
                    UserInfoItems.Add(info);
                }

                this.Invoke(new Action(() => updateUIWithUserData(name, profilePicUrl, coverPicUrl, UserInfoItems)));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => handleDataLoadingError(ex.Message)));
            }
        }

        private void updateUIWithUserData(
            string i_Name,
            string i_ProfilePicUrl,
            string i_CoverPicUrl,
            List<string> i_UserInfoItems)
        {
            StringBuilder infoBuilder = new StringBuilder();

            labelUserName.Text = i_Name;
            profilePictureBox.ImageLocation = i_ProfilePicUrl;
            coverPictureBox.ImageLocation = i_CoverPicUrl;


            listBoxUserInfo.Items.Clear();
            foreach(string userInfo in i_UserInfoItems)
            {
                //listBoxUserInfo.Invoke(new Action(() => listBoxUserInfo.Items.Add(userInfo)));
                infoBuilder.AppendLine(userInfo);
                listBoxUserInfo.Items.Add(userInfo);
            }

            textBoxUserInfo.Text = infoBuilder.ToString();
        }

        private void handleDataLoadingError(string i_ErrorMessage)
        {
            MessageBox.Show($"Error loading user data {i_ErrorMessage}");
        }
    }
}
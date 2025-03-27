using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Backend;
using BasicFacebookFeatures.CustomControls;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Timer = System.Windows.Forms.Timer;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private HigherLowerGameManager m_GameManager;
        //private HigherLowerGameLogic m_HigherLowerGameLogic;
        //private bool m_IsGameInit = false;
        //private Timer m_UiTimer;
        //private Timer m_DelayTimer;

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

        //private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tabControl1.SelectedTab == tabPageHigherLower)
        //    {
        //        if (!m_IsGameInit)
        //        {
        //            m_UiTimer = new Timer();
        //            m_UiTimer.Interval = 1000;
        //            m_UiTimer.Tick += UiTimer_Tick;
        //            initHigherLowerGame();
        //        }
        //    }
        //    else
        //    {
        //        cleanupHigherLowerGame();
        //    }
        //}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageHigherLower)
            {
                if(m_GameManager == null)
                {
                    m_GameManager = new HigherLowerGameManager(
                        labelScore,
                        labelTimer,
                        labelTimeOver,
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
            } else
            {
                m_GameManager.Cleanup();
            }
        }

        //private void UiTimer_Tick(object sender, EventArgs e)
        //{
        //    if (m_HigherLowerGameLogic != null)
        //    {
        //        m_HigherLowerGameLogic.TimerTicks();
        //    }
        //}

        //private void initHigherLowerGame()
        //{
        //    try
        //    {
        //        m_HigherLowerGameLogic = new HigherLowerGameLogic(m_LoggedInUser);

        //        m_HigherLowerGameLogic.PagesSelected += m_HigherLowerGameLogic_PagesSelected;
        //        m_HigherLowerGameLogic.GuessResult += m_HigherLowerGameLogic_GuessResult;
        //        m_HigherLowerGameLogic.GameOver += m_HigherLowerGameLogic_GameOver;
        //        m_HigherLowerGameLogic.TimerTick += m_HigherLowerGameLogic_TimerTick;
        //        m_HigherLowerGameLogic.TimeExpired += m_HigherLowerGameLogic_TimeExpired;

        //        labelScore.Text = "Score: 0";
        //        labelTimer.Text = $"Time: {m_HigherLowerGameLogic.TimeLimit.ToString()}s";
        //        buttonHigherPage1.Enabled = true;
        //        buttonHigherPage2.Enabled = true;
        //        labelTimeOver.Visible = false;

        //        m_UiTimer.Start();

        //        m_HigherLowerGameLogic.StartNewGame();
        //        m_IsGameInit = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            "Error starting the game: " + ex.Message + " Make sure you have liked at least 2 Facebook pages",
        //            "Game Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //        buttonHigherPage1.Enabled = false;
        //        buttonHigherPage2.Enabled = false;
        //    }
        //}

        //private void m_HigherLowerGameLogic_PagesSelected(object sender, PageSelectedEventArgs e)
        //{
        //    this.Invoke(
        //        new Action(
        //            () =>
        //                {
        //                    try
        //                    {
        //                        pictureBoxPage1.ImageLocation = e.FirstPage.PictureURL;
        //                        pictureBoxPage2.ImageLocation = e.SecondPage.PictureURL;

        //                        labelPage1Name.Text = e.FirstPage.Name;
        //                        labelPage2Name.Text = e.SecondPage.Name;

        //                        labelPage1Likes.Visible = false;
        //                        labelPage2Likes.Visible = false;

        //                        buttonHigherPage1.Enabled = true;
        //                        buttonHigherPage2.Enabled = true;
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show(
        //                            "Error displaying pages: " + ex.Message,
        //                            "Error",
        //                            MessageBoxButtons.OK,
        //                            MessageBoxIcon.Error);
        //                    }
        //                }));
        //}

        //private void m_HigherLowerGameLogic_GuessResult(object sender, GuessResultEventArgs e)
        //{
        //    this.Invoke(
        //        new Action(
        //            () =>
        //                {
        //                    try
        //                    {
        //                        labelPage1Likes.Text = $"{e.FirstPageLikesCount:N0} likes";
        //                        labelPage2Likes.Text = $"{e.SecondPageLikesCount:N0} likes";

        //                        labelPage1Likes.Visible = true;
        //                        labelPage2Likes.Visible = true;

        //                        buttonHigherPage1.Enabled = false;
        //                        buttonHigherPage2.Enabled = false;

        //                        labelScore.Text = $"Score: {m_HigherLowerGameLogic.Score}";

        //                        if (m_DelayTimer != null)
        //                        {
        //                            m_DelayTimer.Stop();
        //                            m_DelayTimer.Dispose();
        //                        }

        //                        m_DelayTimer = new Timer();
        //                        m_DelayTimer.Interval = 3000;
        //                        m_DelayTimer.Tick += (s, args) =>
        //                            {
        //                                m_DelayTimer.Stop();
        //                                m_DelayTimer.Dispose();
        //                                m_DelayTimer = null;
        //                            };

        //                        m_DelayTimer.Start();
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show(
        //                            "Error processing guess result: " + ex.Message,
        //                            "Error",
        //                            MessageBoxButtons.OK,
        //                            MessageBoxIcon.Error);
        //                    }
        //                }));
        //}

        //private void m_HigherLowerGameLogic_GameOver(object sender, GameOverEventArgs e)
        //{
        //    this.Invoke(
        //        new Action(
        //            () =>
        //                {
        //                    try
        //                    {
        //                        buttonHigherPage1.Enabled = false;
        //                        buttonHigherPage2.Enabled = false;
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show(
        //                            "Error handling game over: " + ex.Message,
        //                            "Error",
        //                            MessageBoxButtons.OK,
        //                            MessageBoxIcon.Error);
        //                    }
        //                }));
        //}

        //private void m_HigherLowerGameLogic_TimerTick(object sender, TimerEventArgs e)
        //{
        //    this.Invoke(
        //        new Action(
        //            () =>
        //                {
        //                    labelTimer.Text = $"Time: {e.RemainingSeconds.ToString()}s";

        //                    if (e.IsTimeRunningOut)
        //                    {
        //                        labelTimer.ForeColor = Color.Red;
        //                    }
        //                    else
        //                    {
        //                        labelTimer.ForeColor = Color.Blue;
        //                    }
        //                }));
        //}

        //private void m_HigherLowerGameLogic_TimeExpired(object sender, EventArgs e)
        //{
        //    this.Invoke(
        //        new Action(
        //            () =>
        //                {
        //                    Timer timeUpTimer = new Timer();
        //                    timeUpTimer.Interval = 1000;
        //                    timeUpTimer.Tick += (s, args) =>
        //                        {
        //                            timeUpTimer.Stop();
        //                            timeUpTimer.Dispose();

        //                            if (!m_HigherLowerGameLogic.IsGameOver)
        //                            {
        //                                m_HigherLowerGameLogic.HandleTimeExpired();
        //                            }
        //                        };

        //                    timeUpTimer.Start();
        //                }));
        //}

        //private void buttonHigherPage1_Click(object sender, EventArgs e)
        //{
        //    if (m_HigherLowerGameLogic != null)
        //    {
        //        m_HigherLowerGameLogic.MakeGuess(true);
        //    }
        //}

        //private void cleanupHigherLowerGame()
        //{
        //    if(m_HigherLowerGameLogic != null)
        //    {
        //        m_HigherLowerGameLogic.StopTimer();

        //        m_HigherLowerGameLogic.PagesSelected -= m_HigherLowerGameLogic_PagesSelected;
        //        m_HigherLowerGameLogic.GuessResult -= m_HigherLowerGameLogic_GuessResult;
        //        m_HigherLowerGameLogic.GameOver -= m_HigherLowerGameLogic_GameOver;
        //        m_HigherLowerGameLogic.TimerTick -= m_HigherLowerGameLogic_TimerTick;
        //        m_HigherLowerGameLogic.TimeExpired -= m_HigherLowerGameLogic_TimeExpired;
        //    }

        //    if(m_UiTimer != null)
        //    {
        //        m_UiTimer.Stop();
        //        m_UiTimer.Dispose();
        //        m_UiTimer = null;
        //    }

        //    if(m_DelayTimer != null)
        //    {
        //        m_DelayTimer.Stop();
        //        m_DelayTimer.Dispose();
        //        m_DelayTimer = null;
        //    }
        //}
    }
}
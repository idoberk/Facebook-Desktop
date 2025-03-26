using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Backend;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.CustomControls
{
    public partial class HigherLowerGameControl: UserControl
    {
        private const int k_TimeLimitSeconds = 15;
        private HigherLowerGameLogic m_Game;
        private Page m_Page1;
        private Page m_Page2;
        private Timer m_Timer;
        private int m_RemainingSeconds;
        

        public HigherLowerGameControl()
        {
            InitializeComponent();
            initTimer();

            buttonNewGame.Click += buttonNewGame_Click;
        }

        public void InitGame(HigherLowerGameLogic i_Game)
        {
            if (m_Game != null)
            {
                m_Game.PagesSelected -= game_PagesSelected;
                m_Game.GuessResult -= game_GuessResult;
                m_Game.GameOver -= game_GameOver;
            }

            m_Game = i_Game;
            m_Game.PagesSelected += game_PagesSelected;
            m_Game.GuessResult += game_GuessResult;
            m_Game.GameOver += game_GameOver;

            labelScore.Text = "Score: 0";
            labelTimeOver.Visible = false;
        }

        private void initTimer()
        {
            m_Timer = new Timer();
            m_Timer.Interval = 1000;
            m_Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            m_RemainingSeconds--;
            updateTimerDisplay();

            if (m_RemainingSeconds <= 0)
            {
                m_Timer.Stop();
                labelTimeOver.Visible = true;
            }
        }

        private void updateTimerDisplay()
        {
            labelTimer.Text = $"Time: {m_RemainingSeconds}";

            if (m_RemainingSeconds <= 5)
            {
                labelTimer.ForeColor = Color.Red;
            }
            else
            {
                labelTimer.ForeColor = Color.Black;
            }
        }

        private void resetTimer()
        {
            m_RemainingSeconds = k_TimeLimitSeconds;
            updateTimerDisplay();
            m_Timer.Start();
        }

        private void buttonHigherPage2_Click(object sender, EventArgs e)
        {

        }


        private void game_PagesSelected(object sender, PageSelectedEventArgs e)
        {
            m_Page1 = e.FirstPage;
            m_Page2 = e.SecondPage;

            this.Invoke(
                new Action(
                    () =>
                        {
                            labelPage1Name.Text = m_Page1.Name;
                            pictureBoxPage1.ImageLocation = m_Page1.PictureURL;
                            labelPage1Likes.Visible = false;

                            labelPage2Name.Text = m_Page2.Name;
                            pictureBoxPage2.ImageLocation = m_Page2.PictureURL;
                            labelPage2Likes.Visible = false;

                            buttonHigherPage1.Enabled = true;
                            buttonHigherPage2.Enabled = true;

                            labelScore.Text = $"Score: {m_Game.Score}";
                            
                            resetTimer();
                        }));
        }

        private void game_GuessResult(object sender, GuessResultEventArgs e)
        {
            this.Invoke(
                new Action(
                    () =>
                        {
                            m_Timer.Stop();

                            labelPage1Likes.Text = $"{e.FirstPageLikesCount:N0} likes";
                            labelPage1Likes.Visible = true;

                            labelPage2Likes.Text = $"{e.SecondPageLikesCount:N0} likes";
                            labelPage2Likes.Visible = true;

                            buttonHigherPage1.Enabled = false;
                            buttonHigherPage2.Enabled = false;

                            Timer delayTimer = new Timer();

                            delayTimer.Interval = 2000;
                            delayTimer.Tick += (s, args) =>
                                {
                                    delayTimer.Stop();
                                };
                            delayTimer.Start();
                        }));
        }

        private void game_GameOver(object sender, GameOverEventArgs e)
        {
            this.Invoke(
                new Action(
                    () =>
                        {
                            m_Timer.Stop();
                        }));
        }

        private void buttonHigherPage1_Click(object sender, EventArgs e)
        {
            if (m_Game != null)
            {
                m_Game.MakeGuess(true);
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            m_Game?.StartNewGame();
        }
    }
}

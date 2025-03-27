using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.CustomControls;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Backend
{
    public class HigherLowerGameManager
    {
        private readonly Label r_LabelScore;
        private readonly Label r_LabelTimer;
        private readonly Label r_LabelTimeOver;
        private readonly Label r_LabelPage1Name;
        private readonly Label r_LabelPage2Name;
        private readonly Label r_LabelPage1Likes;
        private readonly Label r_LabelPage2Likes;

        private readonly PictureBox r_PictureBoxPage1;
        private readonly PictureBox r_PictureBoxPage2;

        private readonly RoundedButton r_ButtonHigherPage1;
        private readonly RoundedButton r_ButtonHigherPage2;
        private readonly RoundedButton r_ButtonNewGame;

        private readonly Control r_ParentControl;

        private HigherLowerGameLogic m_GameLogic;
        private readonly User r_LoggedInUser;
        private Timer m_UiTimer;
        private Timer m_DelayTimer;
        private bool m_IsGameInit;

        public HigherLowerGameManager(
            Label i_LabelScore,
            Label i_LabelTimer,
            Label i_LabelTimeOver,
            Label i_LabelPage1Name,
            Label i_LabelPage2Name,
            Label i_LabelPage1Likes,
            Label i_LabelPage2Likes,
            PictureBox i_PictureBoxPage1,
            PictureBox i_PictureBoxPage2,
            RoundedButton i_ButtonHigherPage1,
            RoundedButton i_ButtonHigherPage2,
            RoundedButton i_ButtonNewGame,
            Control i_ParentControl,
            User i_LoggedInUser)
        {
            r_LabelScore = i_LabelScore;
            r_LabelTimer = i_LabelTimer;
            r_LabelTimeOver = i_LabelTimeOver;
            r_LabelPage1Name = i_LabelPage1Name;
            r_LabelPage2Name = i_LabelPage2Name;
            r_LabelPage1Likes = i_LabelPage1Likes;
            r_LabelPage2Likes = i_LabelPage2Likes;
            r_PictureBoxPage1 = i_PictureBoxPage1;
            r_PictureBoxPage2 = i_PictureBoxPage2;
            r_ButtonHigherPage1 = i_ButtonHigherPage1;
            r_ButtonHigherPage2 = i_ButtonHigherPage2;
            r_ButtonNewGame = i_ButtonNewGame;
            r_ParentControl = i_ParentControl;
            r_LoggedInUser = i_LoggedInUser;
            m_IsGameInit = false;

            r_ButtonHigherPage1.Click += buttonHigherPage1_Click;
            r_ButtonHigherPage2.Click += buttonHigherPage2_Click;
            r_ButtonNewGame.Click += buttonNewGame_Click;
        }

        public void Initialize()
        {
            if (!m_IsGameInit)
            {
                m_UiTimer = new Timer();

                m_UiTimer.Interval = 1000;
                m_UiTimer.Tick += UiTimer_Tick;
                initHigherLowerGame();
                m_IsGameInit = true;
            }
        }

        private void initHigherLowerGame()
        {
            try
            {
                m_GameLogic = new HigherLowerGameLogic(r_LoggedInUser);

                attachEventHandlers();
                resetUiForNewGame();
                m_UiTimer.Start();
                m_GameLogic.StartNewGame();
            } catch(Exception ex)
            {
                handleGameInitError(ex);
            }
        }

        private void startNewGame()
        {
            if (m_GameLogic != null)
            {
                m_GameLogic.StopTimer();
                resetUiForNewGame();
                m_GameLogic.StartNewGame();
            }
        }

        public void Cleanup()
        {
            if (m_GameLogic != null)
            {
                m_GameLogic.StopTimer();
                detachEventHandlers();
            }

            stopAndDisposeTimers();
            removeButtonEventHandlers();
        }

        private void detachEventHandlers()
        {
            m_GameLogic.PagesSelected -= GameLogic_PagesSelected;
            m_GameLogic.GuessResult -= GameLogic_GuessResult;
            m_GameLogic.GameOver -= GameLogic_GameOver;
            m_GameLogic.TimerTick -= GameLogic_TimerTick;
            m_GameLogic.TimeExpired -= GameLogic_TimeExpired;
        }

        private void attachEventHandlers()
        {
            m_GameLogic.PagesSelected += GameLogic_PagesSelected;
            m_GameLogic.GuessResult += GameLogic_GuessResult;
            m_GameLogic.GameOver += GameLogic_GameOver;
            m_GameLogic.TimerTick += GameLogic_TimerTick;
            m_GameLogic.TimeExpired += GameLogic_TimeExpired;

        }

        private void stopAndDisposeTimers()
        {
            if (m_UiTimer != null)
            {
                m_UiTimer.Stop();
                m_UiTimer.Dispose();
                m_UiTimer = null;
            }

            //if (m_DelayTimer != null)
            //{
            //    m_DelayTimer.Stop();
            //    m_DelayTimer.Dispose();
            //    m_DelayTimer = null;
            //}
        }

        private void removeButtonEventHandlers()
        {
            r_ButtonHigherPage1.Click -= buttonHigherPage1_Click;
            r_ButtonHigherPage2.Click -= buttonHigherPage2_Click;
            r_ButtonNewGame.Click -= buttonNewGame_Click;
        }

        private void resetUiForNewGame()
        {
            r_LabelScore.Text = "Score: 0";
            r_LabelTimer.Text = $"Time: {m_GameLogic.TimeLimit.ToString()}s";
            r_ButtonHigherPage1.Enabled = true;
            r_ButtonHigherPage2.Enabled = true;
            r_LabelTimeOver.Visible = false;
        }

        private void handleGameInitError(Exception i_Exception)
        {
            MessageBox.Show(
                $"Error starting the game: {i_Exception.Message} Make sure you have liked at least 2 Facebook pages",
                "Game Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            r_ButtonHigherPage1.Enabled = false;
            r_ButtonHigherPage2.Enabled = false;
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            if(m_GameLogic != null)
            {
                m_GameLogic.TimerTicks();
            }
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            cleanupExistingDelayTimer();
        }

        private void GameLogic_PagesSelected(object sender, PageSelectedEventArgs e)
        {
            r_ParentControl.Invoke(new Action(() => updatePagesDisplay(e)));
        }

        private void GameLogic_GuessResult(object sender, GuessResultEventArgs e)
        {
            r_ParentControl.Invoke(new Action(() => processGuessResult(e)));
        }

        private void GameLogic_GameOver(object sender, GameOverEventArgs e)
        {
            r_ParentControl.Invoke(new Action(() => handleGameOver(e)));
        }

        private void GameLogic_TimerTick(object sender, TimerEventArgs e)
        {
            r_ParentControl.Invoke(new Action(() => updateTimerDisplay(e)));
        }

        private void GameLogic_TimeExpired(object sender, EventArgs e)
        {
            r_ParentControl.Invoke(new Action(() => handleTimeExpired()));
        }

        private void updatePagesDisplay(PageSelectedEventArgs i_PageData)
        {
            try
            {
                displayPageInfo(i_PageData);
                hidePageLikes();
                enableGuessButtons();
            }
            catch (Exception ex)
            {
                showPageDisplayError(ex);
            }
        }

        private void displayPageInfo(PageSelectedEventArgs i_PageData)
        {
            r_PictureBoxPage1.ImageLocation = i_PageData.FirstPage.PictureURL;
            r_PictureBoxPage2.ImageLocation = i_PageData.SecondPage.PictureURL;

            r_LabelPage1Name.Text = i_PageData.FirstPage.Name;
            r_LabelPage2Name.Text = i_PageData.SecondPage.Name;
        }

        private void hidePageLikes()
        {
            r_LabelPage1Likes.Visible = false;
            r_LabelPage2Likes.Visible = false;
        }

        private void enableGuessButtons()
        {
            r_ButtonHigherPage1.Enabled = true;
            r_ButtonHigherPage2.Enabled = true;
        }

        private void showPageDisplayError(Exception i_Exception)
        {
            MessageBox.Show(
                $"Error displaying pages: {i_Exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void processGuessResult(GuessResultEventArgs i_GuessResult)
        {
            try
            {
                updatePageLikesDisplay(i_GuessResult);
                updateScoreDisplay();
                disableGuessButtons();
                cleanupExistingDelayTimer();

                m_DelayTimer = new Timer();

                m_DelayTimer.Interval = 3000;
                m_DelayTimer.Tick += (s, args) =>
                    {
                        cleanupExistingDelayTimer();

                        m_GameLogic.SelectNextPage(i_GuessResult.IsCorrect);
                    };
                m_DelayTimer.Start();

                // startDelayTimer();
            }
            catch (Exception ex)
            {
                showGuessResultError(ex);
            }
        }

        private void updatePageLikesDisplay(GuessResultEventArgs i_GuessResult)
        {
            r_LabelPage1Likes.Visible = true;
            r_LabelPage2Likes.Visible = true;

            r_LabelPage1Likes.Text = $"{i_GuessResult.FirstPageLikesCount:N0} likes";
            r_LabelPage2Likes.Text = $"{i_GuessResult.SecondPageLikesCount:N0} likes";
        }

        private void updateScoreDisplay()
        {
            r_LabelScore.Text = $"Score: {m_GameLogic.Score}";
        }

        private void disableGuessButtons()
        {
            r_ButtonHigherPage1.Enabled = false;
            r_ButtonHigherPage2.Enabled = false;
        }

        //private void startDelayTimer()
        //{
        //    cleanupExistingDelayTimer();

        //    m_DelayTimer = new Timer();

        //    m_DelayTimer.Interval = 3000;
        //    m_DelayTimer.Tick += DelayTimer_Tick;
        //    m_DelayTimer.Start();
        //}

        private void cleanupExistingDelayTimer()
        {
            if(m_DelayTimer != null)
            {
                m_DelayTimer.Stop();
                m_DelayTimer.Dispose();
                m_DelayTimer = null;
            }
        }

        private void showGuessResultError(Exception i_Exception)
        {
            MessageBox.Show(
                $"Error processing guess result: {i_Exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void handleGameOver(GameOverEventArgs i_GameOverData)
        {
            try
            {
                disableGuessButtons();
                showGameOverMessage(i_GameOverData.FinalScore);
            }
            catch (Exception ex)
            {
                showGameOverError(ex);
            }
        }

        private void showGameOverMessage(int i_FinalScore)
        {
            MessageBox.Show(
                $"Game Over! Your final score is: {i_FinalScore}",
                "Game Over",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void showGameOverError(Exception i_Exception)
        {
            MessageBox.Show(
                $"Error handling game over: {i_Exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void updateTimerDisplay(TimerEventArgs i_TimerData)
        {
            r_LabelTimer.Text = $"Time: {i_TimerData.RemainingSeconds.ToString()}s";
            r_LabelTimer.ForeColor = i_TimerData.IsTimeRunningOut ? Color.Red : Color.Blue;
        }

        private void handleTimeExpired()
        {
            r_LabelTimeOver.Visible = true;
            startTimeExpiredTimer();
        }

        private void startTimeExpiredTimer()
        {
            Timer timeUpTimer = new Timer();
            timeUpTimer.Interval = 1000;
            timeUpTimer.Tick += TimeUpTimer_Tick;
            timeUpTimer.Start();
        }

        private void TimeUpTimer_Tick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;

            timer.Stop();
            timer.Dispose();

            r_LabelTimeOver.Visible = false;

            if (!m_GameLogic.IsGameOver)
            {
                m_GameLogic.HandleTimeExpired();
            }
        }

        private void buttonHigherPage1_Click(object sender, EventArgs e)
        {
            if(m_GameLogic != null)
            {
                m_GameLogic.MakeGuess(true);
            }
        }

        private void buttonHigherPage2_Click(object sender, EventArgs e)
        {
            if(m_GameLogic != null)
            {
                m_GameLogic.MakeGuess(false);
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            startNewGame();
        }
    }
}

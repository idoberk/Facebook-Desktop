using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Backend;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.CustomControls
{
    public partial class HigherLowerGameControl: UserControl
    {
        private const int k_TimeLimitSeconds = 15;
        private User m_LoggedInUser;
        private HigherLowerGame m_Game;
        private Page m_Page1;
        private Page m_Page2;
        private Timer m_Timer;
        private int m_RemainingSeconds;
        

        public HigherLowerGameControl()
        {
            InitializeComponent();
        }

        public void InitGame(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            initTimer();
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
                
            }
        }

        private void updateTimerDisplay()
        {

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
    }
}

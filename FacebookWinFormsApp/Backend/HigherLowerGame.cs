using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Backend
{
    public class HigherLowerGame
    {
        private Page m_CurrentPage;
        private Page m_NextPage;

        public int Score { get; }
        public bool IsGameOver { get; }

        public HigherLowerGame(User i_LoggedInUser)
        {
            Score = 0;
            IsGameOver = false;
        }
    }
}

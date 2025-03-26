using System;

namespace BasicFacebookFeatures.Backend
{
    public class GameOverEventArgs : EventArgs
    {
        public int FinalScore { get; }

        public GameOverEventArgs(int i_FinalScore)
        {
            FinalScore = i_FinalScore;
        }
    }
}

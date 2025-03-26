using System;

namespace BasicFacebookFeatures.Backend
{
    public class GuessResultEventArgs : EventArgs
    {
        public int FirstPageLikesCount { get; }
        public int SecondPageLikesCount { get; }
        public bool IsCorrect { get; }

        public GuessResultEventArgs(int i_FirstPageLikesCount, int i_SecondPageLikesCount, bool i_IsCorrect)
        {
            FirstPageLikesCount = i_FirstPageLikesCount;
            SecondPageLikesCount = i_SecondPageLikesCount;
            IsCorrect = i_IsCorrect;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Backend
{
    public class TimerEventArgs : EventArgs
    {
        public int RemainingSeconds { get; }
        public bool IsTimeRunningOut { get; }

        public TimerEventArgs(int i_RemainingSeconds, bool i_IsTimeRunningOut)
        {
            RemainingSeconds = i_RemainingSeconds;
            IsTimeRunningOut = i_IsTimeRunningOut;
        }
    }
}

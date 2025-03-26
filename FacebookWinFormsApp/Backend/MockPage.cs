using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Backend
{
    public class MockPage : Page
    {
        private readonly long r_FictionalLikesCount;
        private static readonly Random sr_RandomLikesCount = new Random();

        public MockPage(Page i_OriginalPage)
        {
            if (i_OriginalPage.LikesCount == null)
            {
                r_FictionalLikesCount = sr_RandomLikesCount.Next(0, int.MaxValue);
            }
        }
    }
}
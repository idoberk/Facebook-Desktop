using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Backend
{
    public delegate void PagesSelectedEventHandler(object sender, PageSelectedEventArgs e);

    public delegate void GuessResultEventHandler(object sender, GuessResultEventArgs e);

    public delegate void GameOverEventHandler(object sender, GameOverEventArgs e);


    public class HigherLowerGameLogic
    {
        private const int k_TimeLimitSeconds = 15;
        private User m_LoggedInUser;
        private HigherLowerGameLogic m_Game;
        private readonly List<Page> r_UnusedPages = new List<Page>();
        private readonly HashSet<string> r_UsedPageIds = new HashSet<string>();
        private Page m_CurrentWinningPage;
        private Page m_NewChallengingPage;
        private int m_Score;
        private bool m_IsGameOver;
        private static readonly Random sr_RandomPage = new Random();

        public event PagesSelectedEventHandler PagesSelected;
        public event GuessResultEventHandler GuessResult;
        public event GameOverEventHandler GameOver;


        public int Score { get; }

        public bool IsGameOver
        {
            get
            {
                return m_IsGameOver;
            }
        }

        public int RemainingPages
        {
            get
            {
                return r_UnusedPages.Count;
            }
        }

        public HigherLowerGameLogic(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            Score = 0;
            m_IsGameOver = false;

            initPagesList();
        }

        private void initPagesList()
        {
            if (m_LoggedInUser.LikedPages != null && m_LoggedInUser.LikedPages.Count > 0)
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    MockPage mockPage = new MockPage(page);
                    //if (page.LikesCount == null)
                    //{
                    //}
                    
                    r_UnusedPages.Add((Page)mockPage);
                }

                if (r_UnusedPages.Count < 2)
                {
                    throw new Exception("Not enough pages to start the game");
                }

                shufflePages(r_UnusedPages);
            }
            else
            {
                throw new Exception("Not enough pages to start the game");
            }
        }

        public void StartNewGame()
        {
            r_UnusedPages.Clear();
            r_UsedPageIds.Clear();
            initPagesList();
            m_Score = 0;
            m_IsGameOver = false;
        }

        private void shufflePages<T>(List<T> i_List)
        {
            int listCount = i_List.Count;

            for (int i = listCount - 1; i > 0; i--)
            {
                int randomPageIndex = sr_RandomPage.Next(0, i + 1);
                T temp = i_List[i];
                i_List[i] = i_List[randomPageIndex];
                i_List[randomPageIndex] = temp;
            }
        }

        public void MakeGuess(bool i_IsFirstPageHigher)
        {
            if (m_IsGameOver)
            {
                return;
            }

            bool isCorrectGuess;
            bool isFirstPageHigher = m_CurrentWinningPage.LikesCount > m_NewChallengingPage.LikesCount;

            isCorrectGuess = (i_IsFirstPageHigher == isFirstPageHigher);

            if (isCorrectGuess)
            {
                m_Score++;
            }

            OnGuessResult(new GuessResultEventArgs((int)m_CurrentWinningPage.LikesCount, (int)m_NewChallengingPage.LikesCount, isCorrectGuess));

            if (isFirstPageHigher)
            {
                selectNextPage(i_KeepFirstPage: true);
            }
            else
            {
                selectNextPage(i_KeepFirstPage: false);
            }
        }

        private void selectNextPage(bool i_KeepFirstPage)
        {
            Page nextPage = getNextPage();

            if (nextPage != null)
            {
                if (!i_KeepFirstPage)
                {
                    m_CurrentWinningPage = m_NewChallengingPage;
                }

                m_NewChallengingPage = nextPage;
                OnPagesSelected(new PageSelectedEventArgs(m_CurrentWinningPage, m_NewChallengingPage));
            }
            else
            {
                m_IsGameOver = true;
                OnGameOver(new GameOverEventArgs(m_Score));
            }
        }

        private Page getNextPage()
        {
            Page nextPage = null;

            if (r_UnusedPages.Count > 0)
            {
                nextPage = r_UnusedPages[0];
                r_UnusedPages.RemoveAt(0);
                r_UsedPageIds.Add(nextPage.Id);
            }

            return nextPage;
        }

        protected virtual void OnPagesSelected(PageSelectedEventArgs e)
        {
            PagesSelected?.Invoke(this, e);
        }

        protected virtual void OnGuessResult(GuessResultEventArgs e)
        {
            GuessResult?.Invoke(this, e);
        }

        protected virtual void OnGameOver(GameOverEventArgs e)
        {
            GameOver?.Invoke(this, e);
        }
    }
}

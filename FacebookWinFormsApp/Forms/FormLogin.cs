﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookDPApp.Forms
{
    public partial class FormLogin : Form
    {
        private const string k_AppID = "668236632596331";
        private static readonly string[] sr_AppPermissions =
            {
                "public_profile", "email", "user_friends", "user_birthday", "user_posts", "user_gender", "user_photos", "user_age_range", "user_likes", "user_location", "user_hometown"
            };
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;


        public FormLogin()
        {
            InitializeComponent();
            centerButton();
            FacebookService.s_CollectionLimit = 25;
        }

        private void centerButton()
        {
            int x = (ClientSize.Width - buttonLogin.Width) / 2;
            int y = (ClientSize.Height - buttonLogin.Height) / 2;

            buttonLogin.Location = new Point(x, y);
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                m_LoginResult = FacebookService.Connect(
                    "EAAJfwfccn2sBOZC2TMBKc0OQNi3vSeu87BZBvWe79k1g3TVqjfaPNvBnxoyAv46gCSjLaDAVHjVPXqvdGHXHChHZCSJZCs4w0tmCm1xqTpQeUtZCCwrtTOsvZC38dfvqseZBxU3pQBaln0Xgq20F9AepKijWivdKMMQR50uKLrgORFIaDOgRqslnQuuotE5OpiEQ1vIBAmMCKXKYkpd0wZDZD");
                // m_LoginResult = FacebookService.Login(k_AppID, sr_AppPermissions);

                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    FormMain formMain = new FormMain(m_LoggedInUser);
                    this.Hide();
                    formMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Login failed. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
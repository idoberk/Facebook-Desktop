﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormLogin : Form
    {
        private const string k_AppID = "668236632596331";
        private static readonly string[] sr_AppPermissions =
            {
                "public_profile", "email", "user_friends", "user_birthday", "user_posts", "user_link", "user_photos"
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
                m_LoginResult = FacebookWrapper.FacebookService.Connect(
                    "EAAJfwfccn2sBOwN1OE1Gd3ueaWecQlZB59itvBmWVkTLYI79CEZBZAp9lq6xaAx7IVt1ZCgz2dp6ZAPb8EA0W3514f0WFu083uNKOSt40una1EqwAFw1dRw3NpYORo68UWoRMgZBQ7aWHI0Us9QeZAT0kLzElumZBFLXsUWCjg2O9s4OE3vBVlbrUL19nUtnKYvZBzZAuBFVTJejpqA2p55iObHDGk21q4");
                // m_LoginResult = FacebookService.Login(textBoxAppID.Text, sr_AppPermissions);

                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    FormMain formMain = new FormMain(m_LoggedInUser);
                    this.Hide();
                    formMain.ShowDialog();
                    this.Show();
                    // this.Invoke(new Action(this.Close));
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
using BasicFacebookFeatures.Data;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        private AuthRepository Auth { get; set; }
        private MainForm MainForm { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            Auth = new AuthRepository(893455099216824, new string[]
            {
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
            });
        }

        private void buttonLogin_Clicked(object sender, EventArgs e)
        {
            labelTitle.Text = "Waiting for you to log-in";
            AuthRepository.Login();
            if (AuthRepository.LoginResult.AccessToken != null)
            {
                labelTitle.Text = "Logging in, please wait...";
                LoadingForm loadingForm = new LoadingForm();

                loadingForm.Show();
                Hide();
            }
        }
    }
}
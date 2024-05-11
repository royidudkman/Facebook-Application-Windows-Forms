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

        private AuthRepository m_auth;
        private MainForm m_MainForm;
        public LoginForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_auth = new AuthRepository(893455099216824, new string[]
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

        private async void buttonLogin_Clicked(object sender, EventArgs e)
        {
            if (AuthRepository.LoginResult == null)
            {
                LoadingScreen loadingScreen = new LoadingScreen();
                loadingScreen.Show();
                    await Task.Run(() =>
                    {
                        m_auth.Login();
                    });
                    if (string.IsNullOrEmpty(AuthRepository.LoginResult.ErrorMessage))
                    {
                        this.Hide();
                    }
                }
        }
        }
    }



//"publish_to_groups", "pages_read_engagement", "pages_manage_posts" sex_sex_sex555@walla.com
//                      "pages_show_list" ,
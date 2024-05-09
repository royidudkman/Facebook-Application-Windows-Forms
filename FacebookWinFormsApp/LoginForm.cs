﻿using BasicFacebookFeatures.Data;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            m_auth = new AuthRepository(893455099216824, new string[] { "email", "user_birthday", "user_friends" });
        }


        private void buttonLogin_clicked(object sender, EventArgs e)
        {
            if(AuthRepository.LoginResult == null)
            {
                m_auth.Login();
                if (string.IsNullOrEmpty(AuthRepository.LoginResult.ErrorMessage))
                {
                    this.Hide();
                    m_MainForm = new MainForm();
                    m_MainForm.Show();                          
                }
            }

            
        }
    }
}


//"publish_to_groups", "pages_read_engagement", "pages_manage_posts" sex_sex_sex555@walla.com
//                      "pages_show_list" ,
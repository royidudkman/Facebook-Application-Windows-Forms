﻿using BasicFacebookFeatures.interfaces;
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
    public partial class MainForm : Form, ILoginResultReciver
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private BusinessCardScreen BusinessCardScreen { get; set; }
        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AppSettings.LoginResult;
            SetTitleAndProfilePicture();
        }

        public void SetTitleAndProfilePicture()
        {
            labelTitle.Text = $"Welcome {LoginResult.LoggedInUser.FirstName}";
            pictureBoxUserProfile.Image = LoginResult.LoggedInUser.ImageNormal;
            
        }

        private void ButtonCreateBusinessCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusinessCardScreen.Show();    
        }

        private void buttonSendHappyBirthday_Click(object sender, EventArgs e)
        {
            
        }

        public void OnLogin(LoginResult i_LoginResult)
        {
            LoginResult = i_LoginResult;
            SetTitleAndProfilePicture();
        }
    }
}

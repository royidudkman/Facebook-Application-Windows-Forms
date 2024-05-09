using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
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
    public partial class MainForm : Form
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private BusinessCardScreen BusinessCardScreen { get; set; }
        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AuthRepository.LoginResult;
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
            this.Hide();
            BdayScreen bdayScreen = new BdayScreen();
            bdayScreen.Show();
            
        }

     
    }
}

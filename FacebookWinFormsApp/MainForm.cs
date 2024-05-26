using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using BasicFacebookFeatures.Tabs;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
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
    public partial class MainForm : Form
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private PostsTabController postsTabController { get; set; }
        private FriendsTabController friendsTabController { get; set; }
        private AboutTabController aboutTabController { get; set; }
        private PicturesTabController picturesTabController { get; set; }
        private LikedPagesTabController LikedPagesTabController { get; set; }
        private TeamsTabController TeamsTabController { get; set; }
        public static LoadingSpinner LoadingSpinner { get; set; } = new LoadingSpinner();

        public MainForm()
        {
            InitializeComponent();
            LoginResult = AuthRepository.LoginResult;
            postsTabController = new PostsTabController(flowLayoutPanelPosts);
            friendsTabController = new FriendsTabController(flowLayoutPanelFriends);
            aboutTabController = new AboutTabController(flowLayoutPanelAbout);
            picturesTabController = new PicturesTabController(flowLayoutPanelPictures);
            LikedPagesTabController = new LikedPagesTabController(flowLayoutLikedPages);
            TeamsTabController = new TeamsTabController(flowLayoutPanelTeams);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetTitleAndProfilePicture();
            postsTabController.Populate();
            aboutTabController.Populate();
            friendsTabController.Populate();
            picturesTabController.Populate();
            LikedPagesTabController.Populate();
            TeamsTabController.Populate();
        }

        public void SetTitleAndProfilePicture()
        {
            labelTitle.Text = $"Welcome {LoginResult.LoggedInUser.FirstName}";
            pictureBoxUserProfile.Image = LoginResult.LoggedInUser.ImageNormal;
        }

        private void ButtonCreateBusinessCard_Click(object sender, EventArgs e)
        {
            BusinessCardScreen businessCardScreen = new BusinessCardScreen();
            businessCardScreen.Show();
        }

        private void buttonSendHappyBirthday_Click(object sender, EventArgs e)
        {
          
            BdayScreen bdayScreen = new BdayScreen();
            bdayScreen.Show();
        }

        private void buttonCreateNewAlbum_Click(object sender, EventArgs e)
        {
            LoadingSpinner = new LoadingSpinner();
            CreateCanvasScreen albumsCreateScreen = new CreateCanvasScreen();
            LoadingSpinner.Show();
            albumsCreateScreen.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close();
            AuthRepository.LoginResult = null;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}

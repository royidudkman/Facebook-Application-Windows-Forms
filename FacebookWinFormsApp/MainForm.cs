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
        private BusinessCardScreen BusinessCardScreen { get; set; }
        private PostsTabController postsTabController { get; set; }
        private FriendsTabController friendsTabController { get; set; }
        private PicturesTabController picturesTabController { get; set; }
        private LikedPagesTabController LikedPagesTabController { get; set; }
        private TeamsTabController TeamsTabController { get; set; }
        public static LoadingSpinner LoadingSpinner { get; set; } = new LoadingSpinner();

        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AuthRepository.LoginResult;
            postsTabController = new PostsTabController(flowLayoutPanelPosts);
            friendsTabController = new FriendsTabController(flowLayoutPanelFriends);
            picturesTabController = new PicturesTabController(flowLayoutPanelPictures);
            LikedPagesTabController = new LikedPagesTabController(flowLayoutLikedPages);
            TeamsTabController = new TeamsTabController(flowLayoutPanelTeams);
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

        private async void buttonCreateNewAlbum_Click_1(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"First Name: {LoginResult.LoggedInUser.FirstName}\n");
            stringBuilder.Append($"Last Name: {LoginResult.LoggedInUser.LastName}\n");
            stringBuilder.Append($"City: {LoginResult.LoggedInUser.Location.Name}\n");
            stringBuilder.Append($"Email: {LoginResult.LoggedInUser.Email}\n");
            stringBuilder.Append($"Gender: {LoginResult.LoggedInUser.Gender}\n");

            labelInformation.Text = stringBuilder.ToString();
        }

        private  void buttonCreateNewAlbum_Click_1(object sender, EventArgs e)
        {
            LoadingSpinner = new LoadingSpinner();
            this.Hide();
            AlbumsCreateScreen albumsCreateScreen = new AlbumsCreateScreen();
            LoadingSpinner.Show();
            albumsCreateScreen.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            picturesTabController.Initialize();
            SetTitleAndProfilePicture();
            postsTabController.Populate();
            displayAbout();
            friendsTabController.Populate();
            picturesTabController.Initialize();
            LikedPagesTabController.Populate();
            TeamsTabController.Populate();
        }
    }

}

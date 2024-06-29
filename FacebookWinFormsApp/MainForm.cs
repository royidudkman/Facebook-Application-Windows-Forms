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
        private LoginResult LoginResult { get; set; }
        private PostsTabController postsTabController { get; set; }
        private FriendsTabController friendsTabController { get; set; }
        private AboutTabController aboutTabController { get; set; }
        private PicturesTabController picturesTabController { get; set; }
        private LikedPagesTabController LikedPagesTabController { get; set; }
        private TeamsTabController TeamsTabController { get; set; }

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
            new Thread(setTitleAndProfilePicture).Start();
            //new Thread(postsTabController.Populate).Start();
            new Thread(aboutTabController.Populate).Start();
            new Thread(friendsTabController.Populate).Start();
            new Thread(picturesTabController.Populate).Start();
            new Thread(LikedPagesTabController.Populate).Start();
            new Thread(TeamsTabController.Populate).Start();
        }

        private void setTitleAndProfilePicture()
        {
            labelTitle.Invoke(new Action(() => labelTitle.Text = $"Welcome {LoginResult.LoggedInUser.FirstName}"));
            pictureBoxUserProfile.Invoke(new Action(() => pictureBoxUserProfile.Image = LoginResult.LoggedInUser.ImageNormal));
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
            CreateCanvasScreen albumsCreateScreen = new CreateCanvasScreen();
   
            albumsCreateScreen.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close();
            AuthRepository.Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            CreatePostForm createPostForm = new CreatePostForm();

            createPostForm.Show();
        }
    }
}
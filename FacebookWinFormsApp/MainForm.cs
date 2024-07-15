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
        public PostsTabController PostsTabController { get; set; }
        public FriendsTabController FriendsTabController { get; set; }
        public AboutTabController AboutTabController { get; set; }
        public PicturesTabController PicturesTabController { get; set; }
        public LikedPagesTabController LikedPagesTabController { get; set; }
        public TeamsTabController TeamsTabController { get; set; }

        public MainForm()
        {         
            InitializeComponent();
            LoginResult = AuthRepository.LoginResult;
            PostsTabController = new PostsTabController(flowLayoutPanelPosts);
            FriendsTabController = new FriendsTabController(flowLayoutPanelFriends);
            AboutTabController = new AboutTabController(flowLayoutPanelAbout);
            PicturesTabController = new PicturesTabController(flowLayoutPanelPictures);
            LikedPagesTabController = new LikedPagesTabController(flowLayoutLikedPages);
            TeamsTabController = new TeamsTabController(flowLayoutPanelTeams);   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setTitleAndProfilePicture();
        }

        public void initialData()
        {
            PostsTabController.Populate();
            new Thread(FriendsTabController.Populate).Start();
            new Thread(AboutTabController.Populate).Start();
            new Thread(PicturesTabController.Populate).Start();
            new Thread(LikedPagesTabController.Populate).Start();
            new Thread(TeamsTabController.Populate).Start();
        }

        private void setTitleAndProfilePicture()
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
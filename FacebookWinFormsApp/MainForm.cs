using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
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
        private PostsController m_PostsController = new PostsController();
        private DataToCardsFetcher m_DataToCard = new DataToCardsFetcher();
        public static LoadingSpinner LoadingSpinner { get; set; } = new LoadingSpinner();

        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AuthRepository.LoginResult;
            SetTitleAndProfilePicture();
            populateFlowLayoutPanel(flowLayoutPanelPosts, m_PostsController.FetchPosts());
            displayAbout();
            populateFlowLayoutPanel(flowLayoutPanelFriends, m_DataToCard.FetchFriends());
            populateFlowLayoutPanel(flowLayoutLikedPages, m_DataToCard.FetchLikedPages());
            populateFlowLayoutPanel(flowLayoutPanelTeams, m_DataToCard.FetchTeams());

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

        private void displayAbout()
        {
            //WorkExperience[] work = LoginResult.LoggedInUser.WorkExperiences;  //null      
            //Education[] education = LoginResult.LoggedInUser.Educations;//null
            //User.eRelationshipStatus? relationshipStatus = LoginResult.LoggedInUser.RelationshipStatus;// not found
            //FacebookObjectCollection<Group> groups = LoginResult.LoggedInUser.Groups;//not found
            //City hometown = LoginResult.LoggedInUser.Hometown;//not found
            //FacebookObjectCollection<Video> videos = LoginResult.LoggedInUser.Videos;//not found




            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"First Name: {LoginResult.LoggedInUser.FirstName}\n");
            stringBuilder.Append($"Last Name: {LoginResult.LoggedInUser.LastName}\n");
            stringBuilder.Append($"City: {LoginResult.LoggedInUser.Location.Name}\n");
            stringBuilder.Append($"Email: {LoginResult.LoggedInUser.Email}\n");
            stringBuilder.Append($"Gender: {LoginResult.LoggedInUser.Gender}\n");

            labelInformation.Text = stringBuilder.ToString();

            //--------------------------------LATER-------------------------------------------
           
            FacebookObjectCollection<Page> likedPages = LoginResult.LoggedInUser.LikedPages;
            //PicturesColleciton pictures = LoginResult.LoggedInUser.Pictures;
            Page[] teams = LoginResult.LoggedInUser.FavofriteTeams;
            //---------------------------------------------------------------------------------

            return;
        }

  
        private void populateFlowLayoutPanel(FlowLayoutPanel i_FlowLayoutPanel, UserControl[] i_Items)
        {
            for (int i = 0; i < i_Items.Length; i++)
            {
                if (flowLayoutPanelPosts.Controls.Count < 0)
                {
                    i_FlowLayoutPanel.Controls.Clear();
                }
                else
                {
                    i_FlowLayoutPanel.Controls.Add(i_Items[i]);
                }
            }
        }

  

        private async void buttonCreateNewAlbum_Click_1(object sender, EventArgs e)
        {
            LoadingSpinner = new LoadingSpinner();
            this.Hide();
            AlbumsCreateScreen albumsCreateScreen = new AlbumsCreateScreen();
            LoadingSpinner.Show();
            albumsCreateScreen.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}

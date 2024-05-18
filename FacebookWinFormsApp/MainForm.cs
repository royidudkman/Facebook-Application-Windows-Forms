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

        private PostsController m_PostsController = new PostsController();
        private DataToCardsFetcher m_DataToCard = new DataToCardsFetcher();
        public static LoadingSpinner LoadingSpinner { get; set; } = new LoadingSpinner();

        public MainForm()
        {
            InitializeComponent();
            LoginResult = AuthRepository.LoginResult;    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetTitleAndProfilePicture();
            populateFlowLayoutPanel(flowLayoutPanelPosts, m_PostsController.FetchPosts());
            displayAbout();
            populateFlowLayoutPanel(flowLayoutPanelFriends, m_DataToCard.FetchFriends());
            populateFlowLayoutPanel(flowLayoutLikedPages, m_DataToCard.FetchLikedPages());
            populateFlowLayoutPanel(flowLayoutPanelTeams, m_DataToCard.FetchTeams());
            populateFlowLayoutPanel(flowLayoutPanelPictures, m_DataToCard.FetchAlbums());
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
            LoadingSpinner = new LoadingSpinner();
            this.Hide();
            AlbumsCreateScreen albumsCreateScreen = new AlbumsCreateScreen();
            LoadingSpinner.Show();
            albumsCreateScreen.Show();
        }

        private void displayAbout()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"First Name: {LoginResult.LoggedInUser.FirstName}\n");
            stringBuilder.Append($"Last Name: {LoginResult.LoggedInUser.LastName}\n");
            stringBuilder.Append($"City: {LoginResult.LoggedInUser.Location.Name}\n");
            stringBuilder.Append($"Email: {LoginResult.LoggedInUser.Email}\n");
            stringBuilder.Append($"Gender: {LoginResult.LoggedInUser.Gender}\n");

            labelInformation.Text = stringBuilder.ToString();
        }  
  
       
        private void populateFlowLayoutPanel(FlowLayoutPanel i_FlowLayoutPanel, UserControl[] i_Items)
        {
            for (int i = 0; i < i_Items.Length; i++)
            {
                if (i_FlowLayoutPanel.Controls.Count < 0)
                {
                    i_FlowLayoutPanel.Controls.Clear();
                }
                else
                {
                    i_FlowLayoutPanel.Controls.Add(i_Items[i]);
                }
            }
        }
    }
}

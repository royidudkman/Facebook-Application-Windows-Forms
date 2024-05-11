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
        private PictureTabController pictureTabController { get; set; }
        private DataToCardsFetcher m_DataToCard = new DataToCardsFetcher();
        public static LoadingSpinner LoadingSpinner { get; set; } = new LoadingSpinner();

        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AuthRepository.LoginResult;
            pictureTabController = new PictureTabController();
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
            ShowAlbumsOnTheFlowPanel();
        }

        /// <summary>
        /// Picture Tab
        /// </summary>

        private async void ShowAlbumsOnTheFlowPanel()
        {
            await pictureTabController.InitializeAsync();

            foreach (var album in pictureTabController.UserAlbums)
            {
                var albumItem = new AlbumItemControl();
                albumItem.PictureBox.Image = album.ImageAlbum;
                albumItem.PictureBox.Tag = album;
                albumItem.PictureBox.Click += Album_Click;
                albumItem.Label.Text = album.Name;
                flowLayoutPanelPictures.Controls.Add(albumItem);
            }
        }

        private void Album_Click(object sender, EventArgs e)
        {
            clearFlowPanel();
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                Album selectedAlbum = pictureBox.Tag as Album; // Retrieve the associated album
                if (selectedAlbum != null)
                {
                    ShowAllImagesFromSelcetAlbum(selectedAlbum);
                    pictureTabController.UserAlbums.Clear();
                }
            }
        }
        private void Image_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to albums?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                clearFlowPanel();
                pictureTabController.UserPhotos.Clear();
                ShowAlbumsOnTheFlowPanel();
            }
        }
        private async void ShowAllImagesFromSelcetAlbum(Album selectedAlbum)
        {
            await pictureTabController.GetAllUserImagesFromAlbumAsync(selectedAlbum);
            if(pictureTabController.UserPhotos.Count == 0)
            {
                DialogResult result =  MessageBox.Show("There Not Photos In This Album","Eror",MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    ShowAlbumsOnTheFlowPanel();
                }
            }
            else
            {
                LoadingSpinner.Show();
                foreach (var photo in pictureTabController.UserPhotos)
                {
                    var photoItem = new AlbumItemControl(); //TODO : Change the name of this class
                    photoItem.PictureBox.Image = photo.ImageAlbum;
                    photoItem.PictureBox.Click += Image_Click;
                    photoItem.Label.Text = photo.Name;
                    flowLayoutPanelPictures.Controls.Add(photoItem);
                }
                LoadingSpinner.Hide();
            }
          
        }
        private void clearFlowPanel()
        {
            flowLayoutPanelPictures.Controls.Clear();
        }
    }
}

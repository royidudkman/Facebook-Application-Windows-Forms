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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private BusinessCardScreen BusinessCardScreen { get; set; }
        private PostsController m_PostsController = new PostsController();
        private FriendsController m_FriendsController = new FriendsController();

        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AuthRepository.LoginResult;
            SetTitleAndProfilePicture();
            populateFlowLayoutPanel(flowLayoutPanelPosts, m_PostsController.FetchPosts());
            displayAbout();
            populateFlowLayoutPanel(flowLayoutPanelFriends, m_FriendsController.FetchFriends());

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
           
            //FacebookObjectCollection<Page> likedPages = LoginResult.LoggedInUser.LikedPages;
            //PicturesColleciton pictures = LoginResult.LoggedInUser.Pictures;
            //Page[] teams = LoginResult.LoggedInUser.FavofriteTeams;
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
    }
}

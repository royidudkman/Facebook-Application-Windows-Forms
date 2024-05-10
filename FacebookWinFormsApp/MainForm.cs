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

        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AuthRepository.LoginResult;
            SetTitleAndProfilePicture();
            populatePosts(m_PostsController.FetchPosts());

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

      

        private void tabControlFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControlFeed.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // Posts tab
                    //populatePosts(m_PostsController.FetchPosts());
                    break;
                case 1: // About tab
                        // Execute code for the About tab
                    MessageBox.Show("About tab selected");
                    break;
                case 2: // Friends tab
                        // Execute code for the Friends tab
                    MessageBox.Show("Friends tab selected");
                    break;
                case 3: // Pictures tab
                        // Execute code for the Pictures tab
                    MessageBox.Show("Pictures tab selected");
                    break;
                case 4: // Video tab
                        // Execute code for the Video tab
                    MessageBox.Show("Video tab selected");
                    break;
                default:
                    // Handle other tabs or unexpected cases
                    break;
            }
        }
        private void populatePosts(PostItem[] i_Posts)
        {
            for (int i = 0; i < i_Posts.Length; i++)
            {
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(i_Posts[i]);
                }
            }
        }

  

        private void buttonCreateNewAlbum_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AlbumsCreateScreen albumsCreateScreen = new AlbumsCreateScreen();
            albumsCreateScreen.Show();
        }
    }
}

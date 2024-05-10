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
        private PostItem[] m_Posts;

        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
            LoginResult = AuthRepository.LoginResult;
            SetTitleAndProfilePicture();
            populatePosts();


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

        private void populatePosts()
        {
            FacebookObjectCollection<Post> allPosts = LoginResult.LoggedInUser.Posts;

            m_Posts = new PostItem[allPosts.Count];
            for (int i = 0; i < m_Posts.Length; i++)
            {
                m_Posts[i] = new PostItem();
                m_Posts[i].UserName = LoginResult.LoggedInUser.Name;
                m_Posts[i].UserProfilePicture = LoginResult.LoggedInUser.ImageSmall;
                m_Posts[i].PostText = allPosts[i].Message;
                m_Posts[i].PostPictureURL = allPosts[i].PictureURL;

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(m_Posts[i]);
                }
            }
        }

        private void fetchPosts()
        {
            //m_Posts[i] = new PostItem();
            //m_Posts[i].Name = LoginResult.LoggedInUser.Name;
            //m_Posts[i].UserProfilePicture = LoginResult.LoggedInUser.ImageSmall;
            //m_Posts[i].PostText = LoginResult.LoggedInUser.Name;
            //m_Posts[i].PostPicture = LoginResult.LoggedInUser.ImageLarge;

        }

  

        private void buttonCreateNewAlbum_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AlbumsCreateScreen albumsCreateScreen = new AlbumsCreateScreen();
            albumsCreateScreen.Show();
        }
    }
}

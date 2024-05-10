using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using BasicFacebookFeatures.Data;

namespace BasicFacebookFeatures.controllers
{
    internal class PostsController
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private PostItem[] m_Posts;

        public PostsController()
        {
            LoginResult = AuthRepository.LoginResult;
        }

        public PostItem[] FetchPosts()
        {
            FacebookObjectCollection<Post> allPosts = LoginResult.LoggedInUser.Posts;

            m_Posts = new PostItem[allPosts.Count];
            for (int i = 0; i < m_Posts.Length; i++)
            {
                m_Posts[i] = new PostItem();
                m_Posts[i].UserName = allPosts[i].From.ToString();
                m_Posts[i].UserProfilePicture = allPosts[i].From.ImageSmall;
                m_Posts[i].PostText = allPosts[i].Message;
                m_Posts[i].PostPictureURL = allPosts[i].PictureURL;
                m_Posts[i].PostVideoURL = allPosts[i].Source;          
            }

            return m_Posts;
        }
    }
}

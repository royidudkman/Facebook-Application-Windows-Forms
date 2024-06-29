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
using BasicFacebookFeatures.interfaces;

namespace BasicFacebookFeatures.controllers
{
    internal class PostsController
    {
        IFacebookService IFacebookService;

        public PostsController()
        {
            IFacebookService = new FacebookFetcherService();
        }

        public PostItem[] FetchPosts()
        {
            FacebookObjectCollection<Post> allPosts = IFacebookService.FetchPosts();
            PostItem[] allPostItems;
            allPostItems = new PostItem[allPosts.Count];

            for (int i = 0; i < allPostItems.Length; i++)
            {
                allPostItems[i] = new PostItem();
                allPostItems[i].UserName = allPosts[i].From.ToString();
                allPostItems[i].UserProfilePicture = allPosts[i].From.ImageSmall;
                allPostItems[i].PostText = allPosts[i].Message;
                allPostItems[i].PostPictureURL = allPosts[i].PictureURL;
                allPostItems[i].PostVideoURL = allPosts[i].Source;          
            }

            return allPostItems;
        }
    }
}
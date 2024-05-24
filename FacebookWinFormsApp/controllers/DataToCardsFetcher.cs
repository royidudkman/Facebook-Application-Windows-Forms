using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.controllers
{
    internal class DataToCardsFetcher
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private FacebookObjectCollection<User> AllFriends { get; set; }
        private FacebookObjectCollection<Page> AllLikedPages { get; set; }
        private Page[] AllTeams { get; set; }
        private FacebookObjectCollection<Album> AllAlbums { get; set; }

        public DataToCardsFetcher()
        {
            LoginResult = AuthRepository.LoginResult;
        }

        public ImageAndTitleCardItem[] FetchFriends()
        {
            AllFriends = LoginResult.LoggedInUser.Friends;
            ImageAndTitleCardItem[] friendItems;

            if (AllFriends == null || AllFriends.Count == 0)
            {
                friendItems = new ImageAndTitleCardItem[0];
            }

            else
            {
                friendItems = new ImageAndTitleCardItem[AllFriends.Count];
                for (int i = 0; i < friendItems.Length; i++)
                {
                    friendItems[i] = new ImageAndTitleCardItem();
                    friendItems[i].Title = AllFriends[i].Name;
                    friendItems[i].Image = AllFriends[i].ImageSquare;
                }
            }


            return friendItems;
        }

        public ImageAndTitleCardItem[] FetchLikedPages()
        {
            AllLikedPages = LoginResult.LoggedInUser.LikedPages;
            ImageAndTitleCardItem[] likedPagesItems;

            if(AllLikedPages == null || AllLikedPages.Count == 0)
            {
                likedPagesItems = new ImageAndTitleCardItem[0];
            }

            else
            {
                likedPagesItems = new ImageAndTitleCardItem[AllLikedPages.Count];
                for (int i = 0; i < likedPagesItems.Length; i++)
                {
                    likedPagesItems[i] = new ImageAndTitleCardItem();
                    likedPagesItems[i].Title = AllLikedPages[i].Name;
                    likedPagesItems[i].Image = AllLikedPages[i].ImageSquare;
                }
            }
          
            return likedPagesItems;
        }

        public ImageAndTitleCardItem[] FetchTeams()
        {
            AllTeams = LoginResult.LoggedInUser.FavofriteTeams;
            ImageAndTitleCardItem[] teamsItems;

            if(AllTeams == null || AllTeams.Length == 0)
            {
                teamsItems = new ImageAndTitleCardItem[0];
            }

            else
            {
                teamsItems = new ImageAndTitleCardItem[AllTeams.Count()];
                for (int i = 0; i < teamsItems.Length; i++)
                {
                    teamsItems[i] = new ImageAndTitleCardItem();
                    teamsItems[i].Title = AllTeams[i].Name;
                    teamsItems[i].Image = AllTeams[i].ImageSquare;
                }
            }
         
            return teamsItems;
        }
    }
}

using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.controllers
{
    internal class DataToCardsFetcher
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private FacebookObjectCollection<User> AllFriends { get; set; }
        private FacebookObjectCollection<Page> AllLikedPages { get; set; }
        private Page[] AllTeams { get; set; }

        public DataToCardsFetcher()
        {
            LoginResult = AuthRepository.LoginResult;
        }

        public ImageAndTitleCardItem[] FetchFriends()
        {
            AllFriends = LoginResult.LoggedInUser.Friends;

            ImageAndTitleCardItem[] friendItems = new ImageAndTitleCardItem[AllFriends.Count];
            for (int i = 0; i < friendItems.Length; i++)
            {
                friendItems[i] = new ImageAndTitleCardItem();
                friendItems[i].Title = AllFriends[i].Name;
                friendItems[i].Image = AllFriends[i].ImageSquare;
            }

            return friendItems;         
        }

        public ImageAndTitleCardItem[] FetchLikedPages()
        {
            AllLikedPages = LoginResult.LoggedInUser.LikedPages;

            ImageAndTitleCardItem[] likedPagesItems = new ImageAndTitleCardItem[AllLikedPages.Count];
            for (int i = 0; i < likedPagesItems.Length; i++)
            {
                likedPagesItems[i] = new ImageAndTitleCardItem();
                likedPagesItems[i].Title = AllLikedPages[i].Name;
                likedPagesItems[i].Image = AllLikedPages[i].ImageSquare;
            }

            return likedPagesItems;
        }

        public ImageAndTitleCardItem[] FetchTeams()
        {
            AllTeams = LoginResult.LoggedInUser.FavofriteTeams;

            ImageAndTitleCardItem[] teamsItems = new ImageAndTitleCardItem[AllTeams.Count()];
            for (int i = 0; i < teamsItems.Length; i++)
            {
                teamsItems[i] = new ImageAndTitleCardItem();
                teamsItems[i].Title = AllTeams[i].Name;
                teamsItems[i].Image = AllTeams[i].ImageSquare;
            }

            return teamsItems;
        }




    }
}

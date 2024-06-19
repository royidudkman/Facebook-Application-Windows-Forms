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
    public class DataToCardsFetcher
    {
        public ImageAndTitleCardItem[] FetchFriends()
        {
            FacebookObjectCollection<User> allFriends = FacebookFetcherService.FetchFriends();
            ImageAndTitleCardItem[] friendItems;

            if (allFriends == null || allFriends.Count == 0)
            {
                friendItems = new ImageAndTitleCardItem[0];
            }

            else
            {
                friendItems = new ImageAndTitleCardItem[allFriends.Count];

                for (int i = 0; i < friendItems.Length; i++)
                {
                    friendItems[i] = new ImageAndTitleCardItem();

                    friendItems[i].Title = allFriends[i].Name;
                    friendItems[i].Image = allFriends[i].ImageSquare;
                }
            }

            return friendItems;
        }

        public ImageAndTitleCardItem[] FetchLikedPages()
        {
            FacebookObjectCollection<Page> allLikedPages = FacebookFetcherService.FetchLikedPages();
            ImageAndTitleCardItem[] likedPagesItems;

            if(allLikedPages == null || allLikedPages.Count == 0)
            {
                likedPagesItems = new ImageAndTitleCardItem[0];
            }

            else
            {
                likedPagesItems = new ImageAndTitleCardItem[allLikedPages.Count];

                for (int i = 0; i < likedPagesItems.Length; i++)
                {
                    likedPagesItems[i] = new ImageAndTitleCardItem();

                    likedPagesItems[i].Title = allLikedPages[i].Name;
                    likedPagesItems[i].Image = allLikedPages[i].ImageSquare;
                }
            }
          
            return likedPagesItems;
        }

        public ImageAndTitleCardItem[] FetchTeams()
        {
            Page[]  allTeams = FacebookFetcherService.FetchFavofriteTeams();
            ImageAndTitleCardItem[] teamsItems;

            if(allTeams == null || allTeams.Length == 0)
            {
                teamsItems = new ImageAndTitleCardItem[0];
            }

            else
            {
                teamsItems = new ImageAndTitleCardItem[allTeams.Count()];

                for (int i = 0; i < teamsItems.Length; i++)
                {
                    teamsItems[i] = new ImageAndTitleCardItem();

                    teamsItems[i].Title = allTeams[i].Name;
                    teamsItems[i].Image = allTeams[i].ImageSquare;
                }
            }
         
            return teamsItems;
        }
    }
}
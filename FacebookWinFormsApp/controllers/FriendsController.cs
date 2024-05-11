using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.controllers
{
    internal class FriendsController
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private FriendItem[] m_Friends;

        public FriendsController()
        {
            LoginResult = AuthRepository.LoginResult;
        }

        public FriendItem[] FetchFriends()
        {
            FacebookObjectCollection<User> allFriends = LoginResult.LoggedInUser.Friends;

            FriendItem[] friendItems = new FriendItem[allFriends.Count];
            for (int i = 0; i < friendItems.Length; i++)
            {
                friendItems[i] = new FriendItem();
                friendItems[i].Name = allFriends[i].Name;
                friendItems[i].ProfilePicture = allFriends[i].ImageNormal;
            }

            return friendItems;         
        }
    }
}

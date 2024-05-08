using BasicFacebookFeatures.interfaces;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.controllers
{
    internal class BdayController 
    {
         FacebookWrapper.LoginResult LoginResult { get; set; }
         GreetingCard GreetingCard { get; set; }


        public BdayController()
        {
            GreetingCard = new GreetingCard(LoginResult,"");
        }



        public FacebookObjectCollection<FriendList> GetAllAppFriends()
        {
            FacebookObjectCollection<FriendList> userFriends = LoginResult.LoggedInUser.FriendLists;
            if(userFriends.Count > 0)
            {
                return userFriends;
            }
            else
            {
                return null; // there is no friends for this user
            }
            
        }

        public void ShowGreeting()
        {

        }


        public void PostGreeting()
        {

        }

     
    }



}

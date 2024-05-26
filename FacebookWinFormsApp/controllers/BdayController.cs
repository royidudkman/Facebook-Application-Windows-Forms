using BasicFacebookFeatures.Data;
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
       
        public GreetingCard GreetingCard { get; set; }

        public User Friend { get; set; }    

        public eGreetTypes eGreetTypes { get; set; }

        public FacebookObjectCollection<User> GetAllAppFriends()
        {
            FacebookObjectCollection<User> userFriends = FacebookFetcherService.FetchFriends();

            if (userFriends.Count > 0)
            {
                return userFriends;
            }
            else
            {
                throw new Exception(); // there is no friends for this user
            }

        }

        public String CreateAGreetingForFriend(User i_friendToGreet, eGreetTypes eGreetTypes)
        {
            string friendName;
            if(i_friendToGreet != null) 
            { 
                friendName = i_friendToGreet.Name;
            }
            else
            {
                friendName = "My Friend";
            }
            GreetingCard = new GreetingCard(friendName , eGreetTypes);
            return GreetingCard.FormatMessage();
        }

        public void PostGreeting()
        {
            if (GreetingCard != null)
            {
                if (AuthRepository.LoginResult != null && AuthRepository.LoginResult.LoggedInUser != null)
                {
                    AuthRepository.LoginResult.LoggedInUser.PostStatus(GreetingCard.RecipientName);
                }
                else
                {
                    throw new InvalidOperationException("User is not logged in.");
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(GreetingCard), "Greeting card is null.");
            }
        }

    }

    public enum eGreetTypes
    {
        TYPE1,TYPE2,TYPE3,CUSTOM_GREET
    }
}
using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicFacebookFeatures.Data.Enums;

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
                throw new Exception("There are no friends");
            }
        }

        public string CreateAGreetingForFriend(User i_FriendToGreet, eGreetTypes i_eGreetTypes)
        {
            string friendName;

            if (i_FriendToGreet != null)
            {
                friendName = i_FriendToGreet.Name;
            }

            else
            {
                friendName = "My Friend";
            }

            GreetingCard = new GreetingCard(friendName, i_eGreetTypes);

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
}
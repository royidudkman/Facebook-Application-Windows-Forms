using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BasicFacebookFeatures.Data
{
    internal class FacebookFetcherService
    {
        private static FacebookWrapper.LoginResult LoginResult = AuthRepository.LoginResult;

        public static FacebookObjectCollection<User> FetchFriends()
        {
            return LoginResult.LoggedInUser.Friends;
        }

        public static FacebookObjectCollection<Album> FetchAlbums()
        {
            return LoginResult.LoggedInUser.Albums;
        }

        public static FacebookObjectCollection<Photo> FetchPhotosFromAlbum(Album i_UserAlbum)
        {
            FacebookObjectCollection<Photo> userPhotos = new FacebookObjectCollection<Photo>();

            foreach (var image in i_UserAlbum.Photos)
            {
                userPhotos.Add(image);
            }

            return userPhotos;
        }

        public static FacebookObjectCollection<Page> FetchLikedPages()
        {
            return LoginResult.LoggedInUser.LikedPages;
        }

        public static Page[] FetchFavofriteTeams()
        {
            return LoginResult.LoggedInUser.FavofriteTeams;
        }

        public static FacebookObjectCollection<Post> FetchPosts()
        {
            return LoginResult.LoggedInUser.Posts;
        }

        public static UserAbout FetchAbout()
        {
            UserAbout user = new UserAbout();

            user.FirstName = LoginResult.LoggedInUser.Name;
            user.LastName = LoginResult.LoggedInUser.LastName;
            user.Email = LoginResult.LoggedInUser.Email;
            user.Gender = LoginResult.LoggedInUser.Gender;
            user.Location = LoginResult.LoggedInUser.Location;
            user.HomeTown = LoginResult.LoggedInUser.Hometown;
            user.LinkWebsite = LoginResult.LoggedInUser.Link;

            return user;
        }
    }
}
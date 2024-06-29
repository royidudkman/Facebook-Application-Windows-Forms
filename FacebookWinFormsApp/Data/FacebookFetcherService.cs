using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BasicFacebookFeatures.Data
{
    internal class FacebookFetcherService : IFacebookServiceProxy
    {
        private static FacebookWrapper.LoginResult LoginResult = AuthRepository.LoginResult;

        public  FacebookObjectCollection<User> FetchFriends()
        {
            return LoginResult.LoggedInUser.Friends;
        }

        public  FacebookObjectCollection<Album> FetchAlbums()
        {
            //return LoginResult.LoggedInUser.Albums;
            return new FacebookObjectCollection<Album>();          
        }

        public  FacebookObjectCollection<Photo> FetchPhotosFromAlbum(Album i_UserAlbum)
        {
            FacebookObjectCollection<Photo> userPhotos = new FacebookObjectCollection<Photo>();

            foreach (var image in i_UserAlbum.Photos)
            {
                userPhotos.Add(image);
            }

            return userPhotos;
        }

        public  FacebookObjectCollection<Page> FetchLikedPages()
        {
            return LoginResult.LoggedInUser.LikedPages;
        }

        public Page[] FetchFavoriteTeams()
        {
            return LoginResult.LoggedInUser.FavofriteTeams;
        }

        public  FacebookObjectCollection<Post> FetchPosts()
        {
            return LoginResult.LoggedInUser.Posts;
        }

        public  UserAbout FetchAbout()
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
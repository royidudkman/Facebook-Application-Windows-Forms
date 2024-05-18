using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.controllers
{
    internal class PictureTabController
    {
        public int AlbumsCount { get; set; }
        public string Title { get; set; }
        public FacebookObjectCollection<Album> UserAlbums { get; private set; }
        public FacebookObjectCollection<Photo> UserPhotos { get; private set; }

        public PictureTabController()
        {
            AlbumsCount = 0;
            Title = "";
            UserAlbums = new FacebookObjectCollection<Album>();
            UserPhotos = new FacebookObjectCollection<Photo>();
        }

        public void InitializeAsync()
        {
             GetAllUserAlbums();
            // Perform any other initialization tasks here if needed
        }

        //TODO : export this function to new class (AlbumService)
        public void GetAllUserAlbums()
        {
            foreach (var album in AuthRepository.LoginResult.LoggedInUser.Albums)
            {
                UserAlbums.Add(album);
            }
        }


        public void GetAllUserImagesFromAlbum(Album i_UserAlbum)
        {
            foreach (var image in i_UserAlbum.Photos)
            {
                UserPhotos.Add(image);
            }
        }
    }
}

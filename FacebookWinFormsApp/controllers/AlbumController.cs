using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.controllers
{
    internal class AlbumController
    {
        public FacebookObjectCollection<Album> UserAlbums { get; set; }
        public FacebookObjectCollection<Photo> UserPhotos { get; set; }

        public AlbumController()
        {
            UserAlbums = FacebookFetcherService.FetchAlbums();
            UserPhotos = new FacebookObjectCollection<Photo>();
        }

        public void GetAllUserImagesFromAlbum(Album i_UserAlbum)
        {
            UserPhotos.Clear();
            UserPhotos = FacebookFetcherService.FetchPhotosFromAlbum(i_UserAlbum);
        }
    }
}
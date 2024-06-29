using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.controllers
{
    internal class AlbumController
    {
        public FacebookObjectCollection<Album> UserAlbums { get; set; }
        public FacebookObjectCollection<Photo> UserPhotos { get; set; }
        public IFacebookService IFacebookService { get; set; }

        public AlbumController()
        {
            IFacebookService = new FacebookFetcherService();
            UserAlbums = IFacebookService.FetchAlbums();
            UserPhotos = new FacebookObjectCollection<Photo>();
        }

        public void GetAllUserImagesFromAlbum(Album i_UserAlbum)
        {
            UserPhotos.Clear();
            UserPhotos = IFacebookService.FetchPhotosFromAlbum(i_UserAlbum);
        }
    }
}
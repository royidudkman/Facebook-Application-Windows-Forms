using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.controllers
{

    internal class CreateCanvasController : AlbumController
    {
        public int LayoutRaws { get; set; } = 0;
        public int LayoutCols { get; set; } = 0;
        public eLayoutSize LayoutSize { get; set; }

        //public FacebookObjectCollection<Album> UserAlbums { get; private set; }
        //public FacebookObjectCollection<Photo> UserPhotos { get; private set; }

        //public CreateCanvasController()
        //{
        //    //UserAlbums = FacebookFetcherService.FetchAlbums();      
        //}

        public int IndexUserImages
        {
            get { return LayoutRaws; }
            set
            {
                if (value > UserPhotos.Count || value < 0)
                {
                    value = 0;
                }
                LayoutRaws = value;
            }
        }

        //public void GetAllUserImagesFromAlbum(Album i_UserAlbum)
        //{
        //    UserPhotos.Clear();
        //    UserPhotos = FacebookFetcherService.FetchPhotosFromAlbum(i_UserAlbum);
        //}

    }


    enum eLayoutSize
    {
        ONE_ON_TWO,
        THREE_ON_THREE,
        TWO_ON_TWO
    }
}

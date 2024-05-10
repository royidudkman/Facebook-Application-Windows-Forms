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
    
    internal class CreateAlbumController
    {
        public int LayoutRaws { get; set; } = 0;
        public int LayoutCols { get; set; } = 0;
        public eLayoutSize LayoutSize { get; set; }

        public FacebookObjectCollection<Photo> userPhotos { get;  } =  new FacebookObjectCollection<Photo>();

        public int IndexUserImages
        {
            get { return LayoutRaws; }
            set
            {
                if (value > userPhotos.Count || value < 0)
                {
                    value = 0;
                }
                LayoutRaws = value;
            }
        }



        public FacebookObjectCollection<Album> GetAllUserAlbums()
        {
            return AuthRepository.LoginResult.LoggedInUser.Albums;
            
        }

        public void GetAllUserImagesFromAlbum(Album i_UserAlbum)
        {

            foreach (var image in i_UserAlbum.Photos)
            {
                userPhotos.Add(image);
            }
  
        }

    }


    enum eLayoutSize
    {
        ONE_ON_TWO,
        THREE_ON_THREE,
        TWO_ON_TWO
    }
}

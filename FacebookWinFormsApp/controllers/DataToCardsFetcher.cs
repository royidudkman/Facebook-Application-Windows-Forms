using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.controllers
{
    internal class DataToCardsFetcher 
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private FacebookObjectCollection<User> AllFriends { get; set; }
        private FacebookObjectCollection<Page> AllLikedPages { get; set; }
        private Page[] AllTeams { get; set; }
        private FacebookObjectCollection<Album> AllAlbums { get; set; }

        public DataToCardsFetcher()
        {
            LoginResult = AuthRepository.LoginResult;
        }

        public ImageAndTitleCardItem[] FetchFriends()
        {
            AllFriends = LoginResult.LoggedInUser.Friends;

            ImageAndTitleCardItem[] friendItems = new ImageAndTitleCardItem[AllFriends.Count];
            for (int i = 0; i < friendItems.Length; i++)
            {
                friendItems[i] = new ImageAndTitleCardItem();
                friendItems[i].Title = AllFriends[i].Name;
                friendItems[i].Image = AllFriends[i].ImageSquare;
            }

            return friendItems;         
        }

        public ImageAndTitleCardItem[] FetchLikedPages()
        {
            AllLikedPages = LoginResult.LoggedInUser.LikedPages;

            ImageAndTitleCardItem[] likedPagesItems = new ImageAndTitleCardItem[AllLikedPages.Count];
            for (int i = 0; i < likedPagesItems.Length; i++)
            {
                likedPagesItems[i] = new ImageAndTitleCardItem();
                likedPagesItems[i].Title = AllLikedPages[i].Name;
                likedPagesItems[i].Image = AllLikedPages[i].ImageSquare;
            }

            return likedPagesItems;
        }

        public ImageAndTitleCardItem[] FetchTeams()
        {
            AllTeams = LoginResult.LoggedInUser.FavofriteTeams;

            ImageAndTitleCardItem[] teamsItems = new ImageAndTitleCardItem[AllTeams.Count()];
            for (int i = 0; i < teamsItems.Length; i++)
            {
                teamsItems[i] = new ImageAndTitleCardItem();
                teamsItems[i].Title = AllTeams[i].Name;
                teamsItems[i].Image = AllTeams[i].ImageSquare;
            }

            return teamsItems;
        }

        public ImageAndTitleCardItem[] FetchAlbums()
        {
            AllAlbums = LoginResult.LoggedInUser.Albums;

            ImageAndTitleCardItem[] AlbumsImages = new ImageAndTitleCardItem[AllAlbums.Count()];
            for (int i = 0; i < AlbumsImages.Length; i++)
            {
                AlbumsImages[i] = new ImageAndTitleCardItem();
                AlbumsImages[i].Image = AllAlbums[i].ImageAlbum;
                AlbumsImages[i].Title = AllAlbums[i].Name;
                AlbumsImages[i].Tag = AllAlbums[i];
                AlbumsImages[i].Click += AlbumsImages_Click;
            }

            return AlbumsImages;
        }

        private ImageAndTitleCardItem[] getAllImagesFromAlbum(Album i_selectedAlbum)
        {
            FacebookObjectCollection<Photo> allPhotos = i_selectedAlbum.Photos; 

            ImageAndTitleCardItem[] AllImages = new ImageAndTitleCardItem[i_selectedAlbum.Photos.Count];

            for (int i = 0; i < allPhotos.Count; i++)
            {
                AllImages[i] = new ImageAndTitleCardItem();
                AllImages[i].Image = allPhotos[i].ImageAlbum;
                AllImages[i].Title = allPhotos[i].Name;
            }

            return AllImages;
        }

        private void AlbumsImages_Click(object sender, EventArgs e)
        {
            ImageAndTitleCardItem album = sender as ImageAndTitleCardItem;
            ImageGalleryForm galleryForm = new ImageGalleryForm();
            galleryForm.Show();
            //galleryForm.populateGallery(getAllImagesFromAlbum(album.Tag as Album));
        }
    }
}

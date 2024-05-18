//using BasicFacebookFeatures.controllers;
//using FacebookWrapper.ObjectModel;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace BasicFacebookFeatures.Data
//{
//    internal class AlbumManager
//    {
//        private FacebookWrapper.LoginResult LoginResult { get; set; }

//        private PictureTabController m_PictureTabController;
//        public AlbumManager()
//        {
//            LoginResult = AuthRepository.LoginResult;
//        }
//        public AlbumItemControl[] FetchAlbums()
//        {

//        }
//        private async Task<AlbumItemControl[]> ShowAlbumsOnTheFlowPanel(PictureTabController i_PictureTabController)
//        {
//            AlbumItemControl[] albumItems = new AlbumItemControl[i_PictureTabController.UserAlbums.Count];
//            await i_PictureTabController.InitializeAsync();

//            for (int i = 0; i < i_PictureTabController.UserAlbums.Count; i++)
//            {
//                var albumItem = new AlbumItemControl();
//                albumItems[i].PictureBox.Image = i_PictureTabController.UserAlbums[i].ImageAlbum;
//                albumItems[i].PictureBox.Tag = i_PictureTabController.UserAlbums[i];
//                albumItems[i].PictureBox.Click += Album_Click;
//                albumItems[i].Label.Text = i_PictureTabController.UserAlbums[i].Name;

//                //flowLayoutPanelPictures.Controls.Add(albumItem);
//            }
//            return albumItems;
//        }


//        private void Album_Click(object sender, EventArgs e)
//        {
//            clearFlowPanel();
//            PictureBox pictureBox = sender as PictureBox;
//            if (pictureBox != null)
//            {
//                Album selectedAlbum = pictureBox.Tag as Album; // Retrieve the associated album
//                if (selectedAlbum != null)
//                {
//                    ShowAllImagesFromSelcetAlbum(selectedAlbum);
//                    pictureTabController.UserAlbums.Clear();
//                }
//            }
//        }
//        private void Image_Click(object sender, EventArgs e)
//        {
//            DialogResult result = MessageBox.Show("Do you want to go back to albums?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

//            if (result == DialogResult.OK)
//            {
//                clearFlowPanel();
//                pictureTabController.UserPhotos.Clear();
//                ShowAlbumsOnTheFlowPanel();
//            }
//        }
//        private async void ShowAllImagesFromSelcetAlbum(Album selectedAlbum)
//        {
//            await pictureTabController.GetAllUserImagesFromAlbumAsync(selectedAlbum);
//            if (pictureTabController.UserPhotos.Count == 0)
//            {
//                DialogResult result = MessageBox.Show("There Not Photos In This Album", "Eror", MessageBoxButtons.OK);
//                if (result == DialogResult.OK)
//                {
//                    ShowAlbumsOnTheFlowPanel();
//                }
//            }
//            else
//            {
//                LoadingSpinner.Show();
//                foreach (var photo in pictureTabController.UserPhotos)
//                {
//                    var photoItem = new AlbumItemControl(); //TODO : Change the name of this class
//                    photoItem.PictureBox.Image = photo.ImageAlbum;
//                    photoItem.PictureBox.Click += Image_Click;
//                    photoItem.Label.Text = photo.Name;
//                    flowLayoutPanelPictures.Controls.Add(photoItem);
//                }
//                LoadingSpinner.Hide();
//            }

//        }
//        private void clearFlowPanel()
//        {
//            flowLayoutPanelPictures.Controls.Clear();
//        }
//    }
//}

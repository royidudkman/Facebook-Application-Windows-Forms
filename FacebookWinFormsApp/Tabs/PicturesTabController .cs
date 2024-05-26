using BasicFacebookFeatures.controllers;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    public class PicturesTabController : BaseTabController
    {
        private AlbumController AlbumController { get; set; }  
        public PicturesTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            showAlbumsOnTheFlowPanel();
        }

        private void showAlbumsOnTheFlowPanel()
        {
            AlbumController = new AlbumController();

            foreach (var album in AlbumController.UserAlbums)
            {
                var albumItem = new AlbumItemControl();

                albumItem.PictureBox.Image = album.ImageAlbum;
                albumItem.PictureBox.Tag = album;
                albumItem.PictureBox.Click += album_Click;
                albumItem.Label.Text = album.Name;
                FlowLayoutPanel.Controls.Add(albumItem);
            }
        }

        private void album_Click(object sender, EventArgs e)
        {             
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox != null)
            {
                Album selectedAlbum = pictureBox.Tag as Album; 

                if (selectedAlbum != null)
                {
                    showAllImagesFromSelcetAlbum(selectedAlbum);
                }
            }
        }

        private void showAllImagesFromSelcetAlbum(Album selectedAlbum)
        {
            List<AlbumItemControl> allPhotos = new List<AlbumItemControl>();
            ImageGalleryForm galleryForm = new ImageGalleryForm();

            galleryForm.Show();
            AlbumController.GetAllUserImagesFromAlbum(selectedAlbum);
            if (AlbumController.UserPhotos.Count == 0)
            {
                DialogResult result = MessageBox.Show("There Not Photos In This Album", "Error", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    showAlbumsOnTheFlowPanel();
                }
            }

            else
            {
                foreach (var photo in AlbumController.UserPhotos)
                {
                    var photoItem = new AlbumItemControl();

                    photoItem.PictureBox.Image = photo.ImageAlbum;          
                    photoItem.Label.Text = photo.Name;
                    allPhotos.Add(photoItem);                  
                }

                galleryForm.populateGallery(allPhotos);
                AlbumController.UserPhotos.Clear();
            }
        }   
    }
}
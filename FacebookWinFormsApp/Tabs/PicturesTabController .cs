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
        private PictureController pictureTabController = new PictureController();

        public PicturesTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        private FlowLayoutPanel FlowLayoutPanelGallery = new FlowLayoutPanel();

 
        public override void Populate()
        {
            ShowAlbumsOnTheFlowPanel();
        }

        private  void ShowAlbumsOnTheFlowPanel()
        {
             pictureTabController.InitializeAsync();

            foreach (var album in pictureTabController.UserAlbums)
            {
                var albumItem = new AlbumItemControl();
                albumItem.PictureBox.Image = album.ImageAlbum;
                albumItem.PictureBox.Tag = album;
                albumItem.PictureBox.Click += Album_Click;
                albumItem.Label.Text = album.Name;
                FlowLayoutPanel.Controls.Add(albumItem);
            }
        }

        private void Album_Click(object sender, EventArgs e)
        {             
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                Album selectedAlbum = pictureBox.Tag as Album; // Retrieve the associated album
                if (selectedAlbum != null)
                {
                    ShowAllImagesFromSelcetAlbum(selectedAlbum);
                    pictureTabController.UserAlbums.Clear();
                }
            }
        }

    

        private void ShowAllImagesFromSelcetAlbum(Album selectedAlbum)
        {
            List<AlbumItemControl> allPhotos = new List<AlbumItemControl>();
            ImageGalleryForm galleryForm = new ImageGalleryForm();
            galleryForm.Show();

            pictureTabController.GetAllUserImagesFromAlbum(selectedAlbum);
            if (pictureTabController.UserPhotos.Count == 0)
            {
                DialogResult result = MessageBox.Show("There Not Photos In This Album", "Error", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    ShowAlbumsOnTheFlowPanel();
                }
            }

            else
            {
                foreach (var photo in pictureTabController.UserPhotos)
                {
                    var photoItem = new AlbumItemControl(); //TODO : Change the name of this class
                    photoItem.PictureBox.Image = photo.ImageAlbum;          
                    photoItem.Label.Text = photo.Name;
                    allPhotos.Add(photoItem);
                    galleryForm.populateGallery(allPhotos);
  
                }
            }
        }   
    }

}

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
        private PictureTabController pictureTabController = new PictureTabController();

        public PicturesTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Initialize()
        {
            // Initialization logic for pictures
            ShowAlbumsOnTheFlowPanel();
        }

        public override void Populate()
        {
            // This method could be used to populate any additional data if needed
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
            clearFlowPanel();
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

        private void Image_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to albums?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                clearFlowPanel();
                pictureTabController.UserPhotos.Clear();
                ShowAlbumsOnTheFlowPanel();
            }
        }

        private  void ShowAllImagesFromSelcetAlbum(Album selectedAlbum)
        {
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
                    photoItem.PictureBox.Click += Image_Click;
                    photoItem.Label.Text = photo.Name;
                    FlowLayoutPanel.Controls.Add(photoItem);
                }
            }
        }

        private void clearFlowPanel()
        {
            FlowLayoutPanel.Controls.Clear();
        }
    }

}

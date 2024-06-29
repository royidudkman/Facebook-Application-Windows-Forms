using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.interfaces;
using BasicFacebookFeatures.UserControllers;
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
        public event Action PopulateCompleted;

        private AlbumController AlbumController { get; set; }
        private ImageComposite m_RootImageComposite = new ImageComposite();
        public PicturesTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            showAlbumsOnTheFlowPanel();
            PopulateCompleted?.Invoke();
        }

        private void showAlbumsOnTheFlowPanel()
        {
            convertAllAlbumsToComposite();
            m_RootImageComposite.GetChildrens().ForEach(child =>
            {
                FlowLayoutPanel.Controls.Add(child as Control);
            });
        }

        private void convertAllAlbumsToComposite()
        {
            AlbumController = new AlbumController();

            foreach (var album in AlbumController.UserAlbums)
            {
                ImageComposite albumComposite = new ImageComposite();

                foreach (Photo photo in album.Photos)
                {
                    ImageCardItem imageCardItem = new ImageCardItem();
                    imageCardItem.Name = photo.Name;
                    imageCardItem.Image = photo.ImageNormal;
                    albumComposite.AddChild(imageCardItem);
                }

                m_RootImageComposite.AddChild(albumComposite);
            }
        }
    }
}
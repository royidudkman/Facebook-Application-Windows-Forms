using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.interfaces;
using BasicFacebookFeatures.UserControllers;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class ImageGalleryForm : Form
    {
        private List<IActionableImage> m_AllImageItems = new List<IActionableImage>();

        public ImageGalleryForm()
        {
            InitializeComponent();
        }

        public void populateGallery(List<IActionableImage> i_AllImages)
        {
            m_AllImageItems = i_AllImages;
            if (flowLayoutPanelGallery.Controls.Count > 0)
            {
                flowLayoutPanelGallery.Controls.Clear();
            }

            foreach (IActionableImage image in i_AllImages)
            {
                flowLayoutPanelGallery.Controls.Add(image as Control);                
            }
        }    

        private void ToggleControlsVisibility()
        {
            foreach (IActionableImage image in m_AllImageItems)
            {
                image.ToggleCheckBox();
            }

            buttonDeleteAll.Visible = !buttonDeleteAll.Visible;
            buttonAddToFolder.Visible = !buttonAddToFolder.Visible;
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            ToggleControlsVisibility();  
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            foreach (IActionableImage image in m_AllImageItems)
            {
                image.DeleteImage();
            }
        }

        private void buttonAddToFolder_Click(object sender, EventArgs e)
        {
            ImageComposite imageComposite = new ImageComposite();
            List<IActionableImage> newAllImagesItems = new List<IActionableImage>();

            foreach (IActionableImage image in m_AllImageItems)
            {
                if(image.IsChecked())
                {
                    image.ToggleCheckBox();
                    imageComposite.AddChild(image);               
                }
                else
                {
                    newAllImagesItems.Add(image);
                }
            }

            imageComposite.ToggleCheckBox();
            newAllImagesItems.Add(imageComposite);
            populateGallery(newAllImagesItems);
            ToggleControlsVisibility();
        }
    }
}
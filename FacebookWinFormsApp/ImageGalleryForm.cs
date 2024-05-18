using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class ImageGalleryForm : Form
    { 
        public ImageGalleryForm()
        {          
            InitializeComponent();
            labelLoading.Text = "Loading images, please wait";
        }

        public void populateGallery(ImageAndTitleCardItem[] i_allPhotos) 
        {
            for (int i = 0; i < i_allPhotos.Length; i++)
            {
                if (flowLayoutPanelGallery.Controls.Count < 0)
                {
                    flowLayoutPanelGallery.Controls.Clear();
                }
                else
                {
                    flowLayoutPanelGallery.Controls.Add(i_allPhotos[i]);
                }
            }
            labelLoading.Visible = false;
        }
    }
}

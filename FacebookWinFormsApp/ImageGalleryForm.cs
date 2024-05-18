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
        }

        public void populateGallery(List<AlbumItemControl> i_allPhotos)
        {
            if (flowLayoutPanelGallery.Controls.Count > 0)
            {
                flowLayoutPanelGallery.Controls.Clear();
            }

            foreach (var photo in i_allPhotos)
            {
                flowLayoutPanelGallery.Controls.Add(photo);
            }
        }
    }
}

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
    public partial class ImageAndTitleCardItem : UserControl
    {
        public Image Image
        {
            get { return Image; }
            set 
            {
                Image = value; 
                pictureBoxImage.Image = Image;        
            }
        }

        public string Title
        {
            get { return Title; }
            set
            {
                Title = value;
                labelName.Text = Title;
            }
        }

        public ImageAndTitleCardItem()
        {
            InitializeComponent();
        }
    }
}
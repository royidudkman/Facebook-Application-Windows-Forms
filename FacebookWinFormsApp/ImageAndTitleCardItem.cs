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
        private Image m_Image;
        private string m_Title;

        public Image Image
        {
            get { return m_Image; }
            set 
            {
                m_Image = value; 
                pictureBoxProfilePicture.Image = m_Image;
            }
        }

        public string Title
        {
            get { return m_Title; }
            set
            {
                m_Title = value;
                labelName.Text = m_Title;
            }
        }

        public ImageAndTitleCardItem()
        {
            InitializeComponent();
        }
    }
}

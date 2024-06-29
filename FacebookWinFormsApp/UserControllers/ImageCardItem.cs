using BasicFacebookFeatures.interfaces;
using BasicFacebookFeatures.UserControllers;
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
    public partial class ImageCardItem : UserControl, IActionableImage
    {
        private Image m_Image;
        private string m_Title;
        public event EventHandler PictureBoxClicked;
        public event EventHandler CheckBoxChanged;

        public Image Image
        {
            get { return m_Image; }

            set
            {
                m_Image = value;
                pictureBoxImage.Image = m_Image;
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

        

        public ImageCardItem()
        {
            InitializeComponent();
        }

        public void DeleteImage()
        {
            Dispose();
        }

        public void Download()
        {
            throw new NotImplementedException();
        }
        public PictureBox GetImage()
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = m_Image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 100, 
                Height = 100 
            };
            return pictureBox;
        }
      
        private void card_Click(object obj, EventArgs e)
        {
            OpenImageItem();
        }

        public void ToggleCheckBox()
        {
            checkBox.Visible = !checkBox.Visible;
            checkBox.Checked = false;
        }

        public bool IsChecked()
        {
            return checkBox.Checked;
        }

        public void OpenImageItem()
        {
            FullSizeImageForm fullSizeImage = new FullSizeImageForm(); 
            fullSizeImage.Size = m_Image.Size;
            fullSizeImage.Image = m_Image;
            fullSizeImage.Show();
        }
    }
}
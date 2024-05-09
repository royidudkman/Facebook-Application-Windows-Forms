using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class PostItem : UserControl
    {
        private string m_UserName;
        private string m_PostText;
        private string m_PostPictureURL;
        private Image m_UserProfilePicture;



        public string UserName
        {
            get { return m_UserName; }
            set
            {
                m_UserName = value;
                labelName.Text = value;
            }
        }

   

        public string PostText
        {
            get { return m_PostText; }
            set
            {
                if(value != null)
                {
                    m_PostText = value;
                    labelPostText.Text = value;
                }
                else
                {
                    labelPostText.Visible = false;
                }
               
            }
        }

    
        public string PostPictureURL
        {
            get { return m_PostPictureURL; }
            set
            {
                if(value != null)
                {
                    m_PostPictureURL = value;
                    DisplayImageFromUrl(value, pictureBoxPostPicture);
                }
                else
                {
                    pictureBoxPostPicture.Visible = false;
                }
                
            }
        }

        public Image UserProfilePicture
        {
            get { return m_UserProfilePicture; }
            set
            {
                m_UserProfilePicture = value;
                pictureBoxProfilePicture.Image = value;
            }
        }

        public PostItem()
        {
            InitializeComponent();
        }


        private void DisplayImageFromUrl(string imageUrl, PictureBox i_pictureBox)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);

                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(stream);
                        i_pictureBox.Image = image;
                    }
                }
            }

            catch (Exception ex)
            {
                // Handle any errors, e.g., display a default image or show an error message
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

    }
}

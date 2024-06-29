using CefSharp.DevTools.CSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
        private string m_PostVideoURL;
        private Image m_UserProfilePicture;

        public string UserName
        {
            get { return m_UserName; }

            set
            {
                m_UserName = value;
                labelName.Invoke(new Action(() => labelName.Text = value)) ;
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
                    labelPostText.Invoke(new Action(() => labelPostText.Text = value));
                }

                else
                {
                    labelPostText.Invoke(new Action(() => labelPostText.Visible = false));
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
                    pictureBoxPostPicture.Invoke(new Action(() => pictureBoxPostPicture.LoadAsync(value)));
                }

                else
                {
                    pictureBoxPostPicture.Invoke(new Action(() => pictureBoxPostPicture.Visible = false));
                }            
            }
        }

        public string PostVideoURL
        {
            get { return m_PostVideoURL; }

            set
            {
                if(value != null)
                {
                    m_PostVideoURL = value;
                    axWindowsMediaPlayer1.Invoke(new Action(() => axWindowsMediaPlayer1.URL = value));
                    axWindowsMediaPlayer1.Invoke(new Action(() => axWindowsMediaPlayer1.Ctlcontrols.stop()));
                }

                else
                {
                    axWindowsMediaPlayer1.Invoke(new Action(() => axWindowsMediaPlayer1.Visible = false));
                }          
            }
        }
     
        public Image UserProfilePicture
        {
            get { return m_UserProfilePicture; }

            set
            {
                m_UserProfilePicture = value;
                pictureBoxProfilePicture.Invoke(new Action(() => pictureBoxProfilePicture.Image = value));
            }
        }
        public PostItem()
        {
            InitializeComponent();
        }
    }
}
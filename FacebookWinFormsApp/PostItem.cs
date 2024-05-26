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
        public string UserName
        {
            get { return UserName; }

            set
            {
                UserName = value;
                labelName.Text = value;
            }
        }

        public string PostText
        {
            get { return PostText; }
            set
            {
                if(value != null)
                {
                    PostText = value;
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
            get { return PostPictureURL; }
            set
            {
                if(value != null)
                {
                    PostPictureURL = value;
                    pictureBoxPostPicture.LoadAsync(value);
                }

                else
                {
                    pictureBoxPostPicture.Visible = false;
                }         
            }
        }

        public string PostVideoURL
        {
            get { return PostVideoURL; }

            set
            {
                if(value != null)
                {
                    PostVideoURL = value;
                    axWindowsMediaPlayer1.URL = value;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }

                else
                {
                    axWindowsMediaPlayer1.Visible = false;
                }         
            }
        }

        public Image UserProfilePicture
        {
            get { return UserProfilePicture; }

            set
            {
                UserProfilePicture = value;
                pictureBoxProfilePicture.Image = value;
            }
        }

        public PostItem()
        {
            InitializeComponent();
        }
    }
}
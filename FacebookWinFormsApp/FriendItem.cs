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
    public partial class FriendItem : UserControl
    {
        private Image m_ProfilePicture;
        private string m_Name;

        public Image ProfilePicture
        {
            get { return m_ProfilePicture; }
            set 
            {
                m_ProfilePicture = value; 
                pictureBoxProfilePicture.Image = m_ProfilePicture;
            }
        }

        public string Name
        {
            get { return m_Name; }
            set
            {
                m_Name = value;
                labelName.Text = m_Name;
            }
        }

        public FriendItem()
        {
            InitializeComponent();
        }
    }
}

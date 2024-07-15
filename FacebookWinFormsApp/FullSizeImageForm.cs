using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UserControllers
{
    public partial class FullSizeImageForm : Form
    {
        private Image m_Image;
        public Image Image
        {
            get { return m_Image; }

            set
            {
                m_Image = value;
                pictureBox.Image = m_Image;
            }
        }
        public FullSizeImageForm()
        {
            InitializeComponent();
        }
    }
}
using BasicFacebookFeatures.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BasicFacebookFeatures.Post_Decorators
{
    internal class ImageDecorator : BasePost
    {
        public PictureBox PictureBox = new PictureBox();

        public ImageDecorator(IPostable i_Postable) : base(i_Postable)
        {
            setImageToPictureBox();        
        }

        private void setImageToPictureBox()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);
                        PictureBox.Image = selectedImage;
                        PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        PictureBox.Width = 100; 
                        PictureBox.Height = 100;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        public override void AddDecoratorToPanel(FlowLayoutPanel i_flowLayoutPanel)
        {
            i_flowLayoutPanel.Controls.Add(PictureBox);
        }
    }
}
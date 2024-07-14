using BasicFacebookFeatures.interfaces;
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
    public partial class ImageComposite : UserControl, IActionableImage
    {
        private List<IActionableImage> Childs { get; set; } = new List<IActionableImage>();
        private Image CompositeImageCover { get; set; }

        public void AddChild(IActionableImage i_child)
        {
            Childs.Add(i_child);
            CompositeImageCover = CombineImages();
            updateGrid();
        }

        public void RemoveChild(IActionableImage i_child)
        {
            Childs.Remove(i_child);
            updateGrid();
        }

        public List<IActionableImage> GetChildrens()
        {
            return Childs;
        }

        public ImageComposite()
        {
            InitializeComponent();
            updateGrid();
        }

        private void updateGrid()
        {
            tableLayoutPanel1.Controls.Clear();
            int count = Math.Min(4, Childs.Count);
            for (int i = 0; i < count; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = Childs[i].GetImage().Image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                };

                pictureBox.Click += new EventHandler(card_Click);
                int row = i / 2;
                int column = i % 2;
                tableLayoutPanel1.Controls.Add(pictureBox, column, row);
            }
        }

        public PictureBox GetImage()
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = CompositeImageCover,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 100, 
                Height = 100 
            };

            return pictureBox;
        }
        private Image CombineImages()
        {
            int count = Math.Min(4, Childs.Count);
            if (count == 0) 
                return null;

            int imageWidth = 100; 
            int imageHeight = 100; 
            Bitmap combinedImage = new Bitmap(imageWidth * 2, imageHeight * 2);

            using (Graphics g = Graphics.FromImage(combinedImage))
            {
                g.Clear(Color.White); 
                for (int i = 0; i < count; i++)
                {
                    Image childImage = Childs[i].GetImage().Image;
                    if (childImage != null)
                    {
                        int row = i / 2;
                        int col = i % 2;
                        g.DrawImage(childImage, col * imageWidth, row * imageHeight, imageWidth, imageHeight);
                    }
                }
            }
            return combinedImage;
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
            ImageGalleryForm galleryForm = new ImageGalleryForm();
            galleryForm.Show();   
            galleryForm.populateGallery(Childs);
        }
    }
}
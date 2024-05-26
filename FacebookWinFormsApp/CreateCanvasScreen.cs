    using BasicFacebookFeatures.controllers;
    using BasicFacebookFeatures.Data;
    using FacebookWrapper.ObjectModel;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using static BasicFacebookFeatures.Data.Enums;

namespace BasicFacebookFeatures
{
    public partial class CreateCanvasScreen : Form
    {
        CreateCanvasController CreateCanvasController { get; set; }
        //PictureController PictureController { get; set; }

        public CreateCanvasScreen()
        {
            InitializeComponent();
            CreateCanvasController = new CreateCanvasController();
            //PictureController = new PictureController();
        }


        private void AddAlbumsToComboBox()
        {
            //FacebookObjectCollection<Album> userAlbums = await CreateCanvasController.GetAllUserAlbumsAsync();
            FacebookObjectCollection<Album> userAlbums = CreateCanvasController.UserAlbums;
            if (userAlbums != null)
            {
                comboBoxAlbumsNames.DisplayMember = "Name";
                comboBoxAlbumsNames.DataSource = userAlbums;
            }
            else
            {
                comboBoxAlbumsNames.Text = "There Are No Albunms";
            }

        }

        private void CreateTableLayoutFromUserChoice()
        {
            switch (CreateCanvasController.LayoutSize)
            {
                case eLayoutSize.TWO_ON_TWO:
                    {
                        tableLayoutPanel.RowCount = CreateCanvasController.LayoutRaws;
                        tableLayoutPanel.ColumnCount = CreateCanvasController.LayoutCols;
                        break;
                    }
                case eLayoutSize.ONE_ON_TWO:
                    {
                        tableLayoutPanel.RowCount = CreateCanvasController.LayoutRaws;
                        tableLayoutPanel.ColumnCount = CreateCanvasController.LayoutCols;
                        break;
                    }
                case eLayoutSize.THREE_ON_THREE:
                    {
                        tableLayoutPanel.RowCount = CreateCanvasController.LayoutRaws;
                        tableLayoutPanel.ColumnCount = CreateCanvasController.LayoutCols;
                        break;
                    }
            }
            setColAndRowsSameSizeOfTable();
            CreateButtonsForTableLayout();
        }

        private void setColAndRowsSameSizeOfTable()
        {
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tableLayoutPanel.RowCount));
            }

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / tableLayoutPanel.ColumnCount));
            }
        }

        private void CreateButtonsForTableLayout()
        {
            tableLayoutPanel.Controls.Clear();
            for (int i = 0; i < CreateCanvasController.LayoutRaws; i++)
            {
                for (int j = 0; j < CreateCanvasController.LayoutCols; j++)
                {
                    Button addImageBtn = new Button();
                    addImageBtn.Text = "Add Image Here";
                    addImageBtn.Dock = DockStyle.Fill;
                    addImageBtn.Font = new Font("Arial", 10, FontStyle.Bold);
                    tableLayoutPanel.Controls.Add(addImageBtn, j, i);
                    addImageBtn.Click += CreatePictureBoxInsteadButton;
                }
            }
        }

        private void CreatePictureBoxInsteadButton(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                PictureBox pictureBox = new PictureBox();

                // Photo photoSelected = CreateCanvasController.userPhotos.ElementAt(CreateCanvasController.IndexUserImages);
                pictureBox.Image = pictureBoxImagesFromAlbum.Image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox.Location = clickedButton.Location;
                pictureBox.Size = clickedButton.Size;

                TableLayoutPanelCellPosition pos = tableLayoutPanel.GetCellPosition(clickedButton);
                tableLayoutPanel.Controls.Add(pictureBox, pos.Column, pos.Row);

                tableLayoutPanel.Controls.Remove(clickedButton);
            }

            if(CheakTableIsFullInPictures() == true)
            {
                buttonPostImage.Show();
            }

        }

        private void radioButtonTwoOnTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTwoOnTwo.Checked)
            {
                CreateCanvasController.LayoutRaws = 2;
                CreateCanvasController.LayoutCols = 2;
                CreateCanvasController.LayoutSize = eLayoutSize.TWO_ON_TWO;
                CreateTableLayoutFromUserChoice();
                buttonPostImage.Hide();
            }
        }

        private void radioButtonOneOnTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOneOnTwo.Checked)
            {
                CreateCanvasController.LayoutRaws = 1;
                CreateCanvasController.LayoutCols = 2;
                CreateCanvasController.LayoutSize = eLayoutSize.ONE_ON_TWO;
                CreateTableLayoutFromUserChoice();
                buttonPostImage.Hide();

            }
        }

        private void radioButtonThreeOnThree_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThreeOnThree.Checked)
            {
                CreateCanvasController.LayoutRaws = 3;
                CreateCanvasController.LayoutCols = 3;
                CreateCanvasController.LayoutSize = eLayoutSize.THREE_ON_THREE;
                CreateTableLayoutFromUserChoice();
                buttonPostImage.Hide();


            }
        }

        private void comboBoxAlbumsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album choosenAlbum = comboBoxAlbumsNames.SelectedItem as Album;
            CreateCanvasController.GetAllUserImagesFromAlbum(choosenAlbum);
            pictureBoxImagesFromAlbum.Image = choosenAlbum.ImageAlbum;        
            CreateCanvasController.IndexUserImages = 0;
        }

        private void buttonNextImage_Click(object sender, EventArgs e)
        {
            CreateCanvasController.IndexUserImages++;
            if (CreateCanvasController.UserPhotos.Count() > 0)
            {
                Photo photoToPresent = CreateCanvasController.UserPhotos.ElementAt(CreateCanvasController.IndexUserImages);
                pictureBoxImagesFromAlbum.Image = photoToPresent.ImageNormal;
            }
        }

        private void buttonBackImage_Click(object sender, EventArgs e)
        {
            CreateCanvasController.IndexUserImages--;
            if (CreateCanvasController.UserPhotos.Count() > 0)
            {
                Photo photoToPresent = CreateCanvasController.UserPhotos.ElementAt(CreateCanvasController.IndexUserImages);
                pictureBoxImagesFromAlbum.Image = photoToPresent.ImageNormal;
            }
        }

        private void AlbumsCreateScreen_Load(object sender, EventArgs e)
        {
            AddAlbumsToComboBox();
            CreateCanvasController.LayoutRaws = 2;
            CreateCanvasController.LayoutCols = 2;
            CreateCanvasController.LayoutSize = eLayoutSize.TWO_ON_TWO;
            CreateTableLayoutFromUserChoice();
            buttonPostImage.Hide();
 
        }

        private void buttonPostImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg|All files (*.*)|*.*"; 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Bitmap bitmap = new Bitmap(tableLayoutPanel.Width, tableLayoutPanel.Height);
                tableLayoutPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, tableLayoutPanel.Width, tableLayoutPanel.Height));
                bitmap.Save(filePath);
                bitmap.Dispose();
                MessageBox.Show("Table layout saved as image.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheakTableIsFullInPictures()
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (!(control is PictureBox pictureBox))
                {
                    return false;
                }
            }

            return true;
            
        }

    }
}
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

namespace BasicFacebookFeatures
{
    public partial class AlbumsCreateScreen : Form
    {
        CreateAlbumController AlbumController { get; set; }

        public AlbumsCreateScreen()
        {
            InitializeComponent();
            AlbumController = new CreateAlbumController();
        }


        private async void AddAlbumsToComboBox()
        {
            FacebookObjectCollection<Album> userAlbums = await AlbumController.GetAllUserAlbumsAsync();
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

        private void CreateTableLayoutFromUserChoise()
        {
            switch (AlbumController.LayoutSize)
            {
                case eLayoutSize.TWO_ON_TWO:
                    {
                        tableLayoutPanel.RowCount = AlbumController.LayoutRaws;
                        tableLayoutPanel.ColumnCount = AlbumController.LayoutCols;
                        break;
                    }
                case eLayoutSize.ONE_ON_TWO:
                    {
                        tableLayoutPanel.RowCount = AlbumController.LayoutRaws;
                        tableLayoutPanel.ColumnCount = AlbumController.LayoutCols;
                        break;
                    }
                case eLayoutSize.THREE_ON_THREE:
                    {
                        tableLayoutPanel.RowCount = AlbumController.LayoutRaws;
                        tableLayoutPanel.ColumnCount = AlbumController.LayoutCols;
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
            for (int i = 0; i < AlbumController.LayoutRaws; i++)
            {
                for (int j = 0; j < AlbumController.LayoutCols; j++)
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

                // Photo photoSelected = AlbumController.userPhotos.ElementAt(AlbumController.IndexUserImages);
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
                AlbumController.LayoutRaws = 2;
                AlbumController.LayoutCols = 2;
                AlbumController.LayoutSize = eLayoutSize.TWO_ON_TWO;
                CreateTableLayoutFromUserChoise();
                buttonPostImage.Hide();
            }
        }

        private void radioButtonOneOnTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOneOnTwo.Checked)
            {
                AlbumController.LayoutRaws = 1;
                AlbumController.LayoutCols = 2;
                AlbumController.LayoutSize = eLayoutSize.ONE_ON_TWO;
                CreateTableLayoutFromUserChoise();
                buttonPostImage.Hide();

            }
        }

        private void radioButtonThreeOnThree_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThreeOnThree.Checked)
            {
                AlbumController.LayoutRaws = 3;
                AlbumController.LayoutCols = 3;
                AlbumController.LayoutSize = eLayoutSize.THREE_ON_THREE;
                CreateTableLayoutFromUserChoise();
                buttonPostImage.Hide();


            }
        }

        private async void comboBoxAlbumsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumController.userPhotos.Clear();
            Album choosenAlbum = comboBoxAlbumsNames.SelectedItem as Album;
            await AlbumController.GetAllUserImagesFromAlbumAsync(choosenAlbum);
            pictureBoxImagesFromAlbum.Image = choosenAlbum.ImageAlbum;
            await AlbumController.GetAllUserImagesFromAlbumAsync(choosenAlbum);
            AlbumController.IndexUserImages = 0;
        }

        private void buttonNextImage_Click(object sender, EventArgs e)
        {
            AlbumController.IndexUserImages++;
            if (AlbumController.userPhotos.Count() > 0)
            {
                Photo photoToPresent = AlbumController.userPhotos.ElementAt(AlbumController.IndexUserImages);
                pictureBoxImagesFromAlbum.Image = photoToPresent.ImageNormal;
            }
        }

        private void buttonBackImage_Click(object sender, EventArgs e)
        {
            AlbumController.IndexUserImages--;
            if (AlbumController.userPhotos.Count() > 0)
            {
                Photo photoToPresent = AlbumController.userPhotos.ElementAt(AlbumController.IndexUserImages);
                pictureBoxImagesFromAlbum.Image = photoToPresent.ImageNormal;
            }
        }

        private void AlbumsCreateScreen_Load(object sender, EventArgs e)
        {
            AddAlbumsToComboBox();
            AlbumController.LayoutRaws = 2;
            AlbumController.LayoutCols = 2;
            AlbumController.LayoutSize = eLayoutSize.TWO_ON_TWO;
            CreateTableLayoutFromUserChoise();
            buttonPostImage.Hide();
            MainForm.LoadingSpinner.BringToFront();
            MainForm.LoadingSpinner.Hide();
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

using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class BusinessCardScreen : Form
    {
        private const string k_SaveDialogFilter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        private const string k_SaveDialogTitle = "Save Text File";
        private const string k_SuccessMessage = "File saved successfully";
        private const string k_SuccessTitle = "File Saved";
        private const string k_ErrorTitle = "Error";
        private const string k_NoContentMessage = "No content to save.";
        private const string k_InfoTitle = "Information";

        private BusinessCardController BusinessCardController;

        public BusinessCardScreen()
        {
            InitializeComponent();
            BusinessCardController = new BusinessCardController();
        }

        private void checkedListBoxOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((Action)updateRichTextBoxPreview);
        }

        private void updateRichTextBoxPreview()
        {
            StringBuilder previewText = new StringBuilder();

            richTextBoxPreview.Clear();
            foreach (string checkedItem in checkedListBoxOptions.CheckedItems)
            {
                string propertyValue = BusinessCardController.GetInfoFromUser(checkedItem);
                previewText.AppendLine($"{checkedItem}: {propertyValue}");
            }

            richTextBoxPreview.Text = previewText.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBoxPreview.Text))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = k_SaveDialogFilter;
                    saveFileDialog.Title = k_SaveDialogTitle;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        try
                        {
                            File.WriteAllText(filePath, richTextBoxPreview.Text);
                            MessageBox.Show(k_SuccessMessage, k_SuccessTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving file: {ex.Message}", k_ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(k_NoContentMessage, k_InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

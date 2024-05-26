﻿using BasicFacebookFeatures.controllers;
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
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save Text File";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        try
                        {
                            File.WriteAllText(filePath, richTextBoxPreview.Text);
                            MessageBox.Show($"File saved successfully", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No content to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
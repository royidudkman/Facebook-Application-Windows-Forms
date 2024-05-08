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
            UpdateRichTextBoxPreview();
        }

        private void UpdateRichTextBoxPreview()
        {
            StringBuilder previewText = new StringBuilder();

            foreach (string checkedItem in checkedListBoxOptions.CheckedItems)
            {
                string propertyValue = GetPropertyValue(checkedItem);


                previewText.AppendLine($"{checkedItem}: {propertyValue}");
            }

            richTextBoxPreview.Text = previewText.ToString();
        }


        private string GetPropertyValue(string propertyName)
        {
            // Get the value of the property from the BusinessCardController
            switch (propertyName)
            {
                case "Name":
                    return BusinessCardController.BusinessCard.Name;
                case "Last Name":
                    return BusinessCardController.BusinessCard.LastName;
                case "Location":
                    return BusinessCardController.BusinessCard.Location?.ToString();
                case "Home Town":
                    return BusinessCardController.BusinessCard.HomeTown?.ToString();
                case "Gender":
                    return BusinessCardController.BusinessCard.Gender?.ToString();
                case "Link To Website":
                    return BusinessCardController.BusinessCard.LinkWebsite;
                default:
                    return string.Empty;
            }
        }




        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        
    }
}

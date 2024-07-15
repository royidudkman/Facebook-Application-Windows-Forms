using BasicFacebookFeatures.controllers;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BasicFacebookFeatures.Data.Enums;

namespace BasicFacebookFeatures
{
    public partial class BdayScreen : Form
    {
        private const string k_NoFriendsErrorMessage = "There are No Friends";
        private const string k_ErrorTitle = "Error";
        private const string k_ConfirmationMessage = "Are you sure you want to post this greeting?";
        private const string k_ConfirmationTitle = "Confirmation";
        private const string k_SuccessMessage = "Greeting posted successfully.";
        private const string k_SuccessTitle = "Success";
        private const string k_DisplayMemberName = "Name";
        private const MessageBoxButtons k_OkButton = MessageBoxButtons.OK;
        private const MessageBoxIcon k_ErrorIcon = MessageBoxIcon.Error;
        private const MessageBoxIcon k_QuestionIcon = MessageBoxIcon.Question;
        private const MessageBoxIcon k_InformationIcon = MessageBoxIcon.Information;
        BdayController BdayController { get; set; }

        public BdayScreen()
        {
            InitializeComponent();
            BdayController = new BdayController();
        }

        private void BdayScreen_Load(object sender, EventArgs e)
        {
            showAllUserFriends();
        }

        private void showAllUserFriends()
        {
            try
            {
                FacebookObjectCollection<User> userFriends = BdayController.GetAllAppFriends();

                listBoxUserFriends.DisplayMember = k_DisplayMemberName;
                foreach (User friend in userFriends)
                {
                    listBoxUserFriends.Items.Add(friend);
                }
            }

            catch
            {
                MessageBox.Show(k_NoFriendsErrorMessage, k_ErrorTitle, k_OkButton, k_ErrorIcon);
            }
        }

        private void showHappyBdayOnTextBox(string i_greetHappyBdayText)
        {
            richTextBoxGreeting.Text = i_greetHappyBdayText;
        }

        private void listBoxUserFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            BdayController.Friend = listBoxUserFriends.SelectedItem as User;
        }

        private void buttonPostBlessing_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmationResult = MessageBox.Show(k_ConfirmationMessage, k_ConfirmationTitle, MessageBoxButtons.YesNo, k_QuestionIcon);

                if (confirmationResult == DialogResult.Yes)
                {
                    BdayController.PostGreeting();
                    MessageBox.Show(k_SuccessMessage, k_SuccessTitle, k_OkButton, k_InformationIcon);
                }
            }

            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message, k_ErrorTitle, k_OkButton, k_ErrorIcon);
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, k_ErrorTitle, k_OkButton, k_ErrorIcon);
            }

            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, k_ErrorTitle, k_OkButton, k_ErrorIcon);
            }
        }

        private void radioButtonGreetType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreetType1.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.TYPE1;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                showHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }

            else if (radioButtonGreetType2.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.TYPE2;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                showHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }

            else if (radioButtonGreetType3.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.TYPE3;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                showHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }

            else if (radioButtonCustomGreed.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.CUSTOM_GREET;
                BdayController.GreetingCard.Message = richTextBoxGreeting.Text;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                showHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }
        }
    }
}
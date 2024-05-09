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

namespace BasicFacebookFeatures
{
    public partial class BdayScreen : Form
    {
        BdayController BdayController { get; set; }


        public BdayScreen()
        {
            InitializeComponent();
            BdayController = new BdayController();
            ShowAllUserFriends();
        }


        private void ShowAllUserFriends()
        {
            try
            {
                FacebookObjectCollection<User> userFriends = BdayController.GetAllAppFriends();
                listBoxUserFriends.DisplayMember = "Name";
                //TODO: tell the user that he doesnt have any friends
                foreach (User friend in userFriends)
                {
                    listBoxUserFriends.Items.Add(friend);
                }
            }
            catch
            {
                MessageBox.Show("There Is No Friends", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ShowHappyBdayOnTextBox(string i_greetHappyBdayText)
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
                // Show a dialog to confirm that the user wants to post
                DialogResult confirmationResult = MessageBox.Show("Are you sure you want to post this greeting?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmationResult == DialogResult.Yes)
                {
                    BdayController.PostGreeting();

                    MessageBox.Show("Greeting posted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void radioButtonGreetType1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreetType1.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.TYPE1;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                ShowHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }
        }

        private void radioButtonGreetType2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreetType2.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.TYPE2;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                ShowHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }
        }

        private void radioButtonGreetType3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreetType3.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.TYPE3;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                ShowHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }
        }



        private void radioButtonCustomGreet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomGreed.Checked)
            {
                BdayController.eGreetTypes = eGreetTypes.CUSTOM_GREET;
                BdayController.GreetingCard.Message = richTextBoxGreeting.Text;
                BdayController.CreateAGreetingForFriend(BdayController.Friend, BdayController.eGreetTypes);
                ShowHappyBdayOnTextBox(BdayController.GreetingCard.FormatMessage());
            }
        }
    }

    
}

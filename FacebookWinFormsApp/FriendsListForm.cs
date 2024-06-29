using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FriendsListForm : Form
    {
        public User SelectedFriend { get; set; }
        public IFacebookServiceProxy IFacebookServiceProxy { get; set; }
        public FriendsListForm()
        {
            InitializeComponent();
            IFacebookServiceProxy = new FacebookServiceProxy();
            userBindingSource.DataSource = IFacebookServiceProxy.FetchFriends();
        }

        private void buttonTag_Click(object sender, EventArgs e)
        {
            SelectedFriend = listBoxFriends.SelectedItem as User;
            Close();
        }
    }
}
using BasicFacebookFeatures.interfaces;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Post_Decorators
{
    internal class TagFriendDecorator : BasePost
    {
        public User FriendTagged { get; set; }
        public TagFriendDecorator(IPostable i_Postable) : base(i_Postable)
        {
            setFriends();
        }

        private void setFriends()
        {
            using (FriendsListForm friendsListForm = new FriendsListForm())
            {
                friendsListForm.ShowDialog();
                FriendTagged = friendsListForm.SelectedFriend;
            }     
        }

        public override void AddDecoratorToPanel(FlowLayoutPanel i_FlowLayoutPanel)
        {
            Label label = new Label();
            if (FriendTagged != null)
            {
                label.Text = FriendTagged.Name;
                i_FlowLayoutPanel.Controls.Add(label);
            }          
        }
    }
}
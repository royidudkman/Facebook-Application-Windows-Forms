using BasicFacebookFeatures.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    public class FriendsTabController : BaseTabController
    {
        private DataToCardsFetcher m_DataToCard = new DataToCardsFetcher();


        public FriendsTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            var friends = m_DataToCard.FetchFriends();
            foreach (var friend in friends)
            {
                FlowLayoutPanel.Controls.Add(friend);
            }
        }
    }

}

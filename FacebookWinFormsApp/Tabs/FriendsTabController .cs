﻿using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.interfaces;
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
        private IUserCardsFetcher IuserCardsFetcher = new DataToCardsFetcherAdapter();
        public FriendsTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            var friendsCards = IuserCardsFetcher.GetFriendsCards();

            foreach (var friendCard in friendsCards)
            {
                FlowLayoutPanel.Controls.Add(friendCard as ImageAndTitleCardItem);
            }
        }
    }
}
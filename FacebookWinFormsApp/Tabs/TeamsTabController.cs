using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    public class TeamsTabController : BaseTabController
    {
        private IUserCardsFetcher IuserCardsFetcher = new DataToCardsFetcherAdapter();
        public TeamsTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            var teamsCards = IuserCardsFetcher.GetTeamsCards();

            foreach (var teamCard in teamsCards)
            {
                FlowLayoutPanel.Controls.Add(teamCard as ImageAndTitleCardItem);
            }
        }
    }
}
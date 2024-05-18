using BasicFacebookFeatures.controllers;
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
        private DataToCardsFetcher m_DataToCard = new DataToCardsFetcher();

        public TeamsTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Initialize()
        {
            // Initialization logic for friends
        }

        public override void Populate()
        {
            var teams = m_DataToCard.FetchTeams();
            foreach (var team in teams)
            {
                FlowLayoutPanel.Controls.Add(team);
            }
        }
    }
}

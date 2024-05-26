using BasicFacebookFeatures.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    public class LikedPagesTabController : BaseTabController
    {
        private DataToCardsFetcher m_DataToCard = new DataToCardsFetcher();
        public LikedPagesTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            var likedPages = m_DataToCard.FetchLikedPages();

            foreach (var likedPage in likedPages)
            {
                FlowLayoutPanel.Controls.Add(likedPage);
            }
        }
    }
}
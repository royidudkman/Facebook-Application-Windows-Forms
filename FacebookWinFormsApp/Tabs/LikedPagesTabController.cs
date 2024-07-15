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
    public class LikedPagesTabController : BaseTabController
    {
        public event Action PopulateCompleted;
        private IUserCardsFetcher IuserCardsFetcher = new DataToCardsFetcherAdapter();

        public LikedPagesTabController(FlowLayoutPanel i_FlowLayoutPanel) : base(i_FlowLayoutPanel) { }

        public override void Populate()
        {
            var likedPagesCards = IuserCardsFetcher.GetLikedPagesCards();

            foreach (var likedPagecard in likedPagesCards)
            {
                FlowLayoutPanel.Controls.Add(likedPagecard as ImageAndTitleCardItem);
            }

            PopulateCompleted?.Invoke();
        }
    }
}
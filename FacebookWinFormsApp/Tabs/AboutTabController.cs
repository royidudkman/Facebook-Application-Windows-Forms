using BasicFacebookFeatures.Data;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    internal class AboutTabController : BaseTabController
    {
        public AboutTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            UserAbout user = FacebookFetcherService.FetchAbout();
            string info = $"{(user?.FirstName != null ? $"First Name: {user.FirstName}{Environment.NewLine}" : string.Empty)}" +
            $"{(user?.LastName != null ? $"Last Name: {user.LastName}{Environment.NewLine}" : string.Empty)}" +
            $"{(user?.Location?.Name != null ? $"City: {user.Location.Name}{Environment.NewLine}" : string.Empty)}" +
            $"{(user?.Email != null ? $"Email: {user.Email}{Environment.NewLine}" : string.Empty)}" +
            $"{(user?.Gender != null ? $"Gender: {user.Gender}{Environment.NewLine}" : string.Empty)}";
            Label aboutInfoLabel = new Label
            {
                Text = info,
                AutoSize = true,
                Font = new Font("Arial", 16)
            };

            FlowLayoutPanel.Controls.Add(aboutInfoLabel);
        }
    }
}
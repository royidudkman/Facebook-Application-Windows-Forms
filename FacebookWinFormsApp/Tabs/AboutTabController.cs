using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
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
    public class AboutTabController : BaseTabController
    {
        public event Action PopulateCompleted;
        public IFacebookServiceProxy IFacebookService { get; set; }
       
        public AboutTabController(FlowLayoutPanel i_FlowLayoutPanel) : base(i_FlowLayoutPanel)
        {
            IFacebookService = new FacebookServiceProxy();
        }

        public override void Populate()
        {
            UserAbout user = IFacebookService.FetchAbout();
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
            PopulateCompleted?.Invoke();
        }
    }
}
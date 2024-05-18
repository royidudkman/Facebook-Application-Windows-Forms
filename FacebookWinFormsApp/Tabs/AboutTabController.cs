using BasicFacebookFeatures.Data;
using FacebookWrapper;
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
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        public AboutTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel)
        {
            LoginResult = AuthRepository.LoginResult;
        }

        public override void Populate()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"First Name: {LoginResult.LoggedInUser.FirstName}{Environment.NewLine}");
            stringBuilder.Append($"Last Name: {LoginResult.LoggedInUser.LastName}{Environment.NewLine}");
            stringBuilder.Append($"City: {LoginResult.LoggedInUser.Location.Name}{Environment.NewLine}");
            stringBuilder.Append($"Email: {LoginResult.LoggedInUser.Email}{Environment.NewLine}");
            stringBuilder.Append($"Gender: {LoginResult.LoggedInUser.Gender}{Environment.NewLine}");

            Label aboutInfoLabel = new Label
            {
                Text = stringBuilder.ToString(),
                AutoSize = true,
                Font = new Font("Arial", 16) 
            };

            FlowLayoutPanel.Controls.Add(aboutInfoLabel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures.Data
{
    internal class BusinessCard
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private string Name { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private eGender? Gender { get; set; }
        private FacebookWrapper.ObjectModel.City Location { get; set; }
        private FacebookWrapper.ObjectModel.City HomeTown { get; set; }
        private string LinkWebsite { get; set; }

        public BusinessCard(FacebookWrapper.LoginResult i_loginResult)
        {    
            LoginResult = i_loginResult;
            Name = LoginResult.LoggedInUser.Name;
            LastName = LoginResult.LoggedInUser.LastName;
            Email = LoginResult.LoggedInUser.Email;
            Gender = LoginResult.LoggedInUser.Gender;
            Location = LoginResult.LoggedInUser.Location;
            HomeTown = LoginResult.LoggedInUser.Hometown;
            LinkWebsite = LoginResult.LoggedInUser.Link;
        }

       
        public string BusinessCardFormat()
        {
            StringBuilder businessCardBuilder = new StringBuilder();

            businessCardBuilder.AppendLine("Name: " + Name);
            businessCardBuilder.AppendLine("Last Name: " + LastName);
            businessCardBuilder.AppendLine("Email: " + Email);
            businessCardBuilder.AppendLine("Gender: " + Gender);
            businessCardBuilder.AppendLine("Location: " + Location);
            businessCardBuilder.AppendLine("HomeTown: " + HomeTown);
            businessCardBuilder.AppendLine("Website: " + LinkWebsite);

            return businessCardBuilder.ToString();
        }

    }
}

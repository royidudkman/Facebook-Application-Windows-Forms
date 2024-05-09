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
        public FacebookWrapper.LoginResult LoginResult { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public eGender? Gender { get; set; }
        public FacebookWrapper.ObjectModel.City Location { get; set; }
        public FacebookWrapper.ObjectModel.City HomeTown { get; set; }
        public string LinkWebsite { get; set; }

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

         

    }
}

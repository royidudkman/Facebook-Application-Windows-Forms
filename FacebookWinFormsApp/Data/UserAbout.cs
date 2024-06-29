using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures.Data
{
    public class UserAbout
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public eGender? Gender { get; set; }
        public FacebookWrapper.ObjectModel.City Location { get; set; }
        public FacebookWrapper.ObjectModel.City HomeTown { get; set; }
        public string LinkWebsite { get; set; }         
    }
}
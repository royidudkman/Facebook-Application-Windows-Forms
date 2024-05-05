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
        private FacebookWrapper.LoginResult m_LoginResult;
        private string m_Name;
        private string m_LastName;
        private string m_Email;
        private eGender? m_Gender;
        private FacebookWrapper.ObjectModel.City m_Location;
        private FacebookWrapper.ObjectModel.City m_HomeTown;
        private string m_LinkWebsite;

        public BusinessCard(FacebookWrapper.LoginResult i_loginResult)
        {
            m_LoginResult = i_loginResult;
            Name = m_LoginResult.LoggedInUser.Name;
            LastName = m_LoginResult.LoggedInUser.LastName;
            Email = m_LoginResult.LoggedInUser.Email;
            Gender = m_LoginResult.LoggedInUser.Gender;
            Location = m_LoginResult.LoggedInUser.Location;
            HomeTown = m_LoginResult.LoggedInUser.Hometown;
            LinkWebsite = m_LoginResult.LoggedInUser.Link;
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }

        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        public eGender? Gender
        {
            get { return m_Gender; }
            set { m_Gender = value; }
        }

        public FacebookWrapper.ObjectModel.City Location
        {
            get { return m_Location; }
            set { m_Location = value; }
        }

        public FacebookWrapper.ObjectModel.City HomeTown
        {
            get { return m_HomeTown; }
            set { m_HomeTown = value; }
        }

        public string LinkWebsite
        {
            get { return m_LinkWebsite; }
            set { m_LinkWebsite = value; }
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

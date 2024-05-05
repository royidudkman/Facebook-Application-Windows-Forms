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
        private string m_Name;
        private string m_LastName;
        private string m_Phone;
        private string m_Email;
        private string m_Gender;
        private string m_Location;
        private string m_HomeTown;
        private string m_LinkWebsite;

        public BusinessCard(string name, string lastName, string phone, string email, string gender, string location, string homeTown, string linkWebsite)
        {
            Name = name;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Gender = gender;
            Location = location;
            HomeTown = homeTown;
            LinkWebsite = linkWebsite;
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

        public string Phone
        {
            get { return m_Phone; }
            set { m_Phone = value; }
        }

        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        public string Gender
        {
            get { return m_Gender; }
            set { m_Gender = value; }
        }

        public string Location
        {
            get { return m_Location; }
            set { m_Location = value; }
        }

        public string HomeTown
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
            businessCardBuilder.AppendLine("Phone: " + Phone);
            businessCardBuilder.AppendLine("Email: " + Email);
            businessCardBuilder.AppendLine("Gender: " + Gender);
            businessCardBuilder.AppendLine("Location: " + Location);
            businessCardBuilder.AppendLine("HomeTown: " + HomeTown);
            businessCardBuilder.AppendLine("Website: " + LinkWebsite);

            return businessCardBuilder.ToString();
        }

    }
}

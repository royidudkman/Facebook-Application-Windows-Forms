using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace BasicFacebookFeatures.controllers
{
    internal class BusinessCardController 
    {
        public BusinessCard BusinessCard { get; set; }

        public BusinessCardController()
        {
            BusinessCard = new BusinessCard(AuthRepository.LoginResult);
             
        }

        public string BusinessCardFormat()
        {
            StringBuilder businessCardBuilder = new StringBuilder();

            businessCardBuilder.AppendLine("Name: " + BusinessCard.Name);
            businessCardBuilder.AppendLine("Last Name: " + BusinessCard.LastName);
            businessCardBuilder.AppendLine("Email: " + BusinessCard.Email);
            businessCardBuilder.AppendLine("Gender: " + BusinessCard.Gender);
            businessCardBuilder.AppendLine("Location: " + BusinessCard.Location);
            businessCardBuilder.AppendLine("HomeTown: " + BusinessCard.HomeTown);
            businessCardBuilder.AppendLine("Website: " + BusinessCard.LinkWebsite);

            return businessCardBuilder.ToString();
        }



    }
}

using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static BasicFacebookFeatures.Data.Enums;

namespace BasicFacebookFeatures
{
    internal class GreetingCard
    {
        public string SenderName { get; set; }
        public string RecipientName { get; set; }
        public string Message { get; set; }
        public eGreetTypes eGreetTypes { get; set; }
        public List<string> Attachment { get; set; }

        public GreetingCard(string i_RecipientName, eGreetTypes i_eGreetTypes = eGreetTypes.TYPE1)
        {
            SenderName = AuthRepository.LoginResult.LoggedInUser.Name;
            RecipientName = i_RecipientName;
            Attachment = new List<string>();

            switch (i_eGreetTypes)
            {
                case eGreetTypes.TYPE1:
                    Message = Resources.GreetType1;
                    break;
                case eGreetTypes.TYPE2:
                    Message = Resources.GreetType2;
                    break;
                case eGreetTypes.TYPE3:
                    Message = Resources.GreetType3;
                    break;
                case eGreetTypes.CUSTOM_GREET:
                    Message = "";
                    break;
            }
        }

        public void AddAttachment(string i_Attachment)
        {
            Attachment.Add(i_Attachment);
        }

        public string FormatMessage()
        {
            StringBuilder happyBdayBuilder = new StringBuilder();
            happyBdayBuilder.AppendLine("Dear : " + RecipientName);
            happyBdayBuilder.AppendLine(Message);
            happyBdayBuilder.AppendLine("From : " + SenderName);
            return happyBdayBuilder.ToString();
        }
    }
}
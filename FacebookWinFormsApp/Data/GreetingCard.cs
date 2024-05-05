using BasicFacebookFeatures.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class GreetingCard
    {
        private FacebookWrapper.LoginResult LoginResult { get; set; }
        private string SenderName { get; set; }
        private string RecipientName { get; set; }
        private string Message { get; }
        private List<string> Attachment { get; set; }

        public GreetingCard(FacebookWrapper.LoginResult i_loginResult , string i_recipientName)
        {
            LoginResult = i_loginResult;
            SenderName = i_loginResult.LoggedInUser.Name;
            RecipientName = i_recipientName;
            Message = Resources.greeting;
            Attachment = new List<string>();
        }


        public void AddAttachment(string attachment)
        {
            Attachment.Add(attachment);
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

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
        private FacebookWrapper.LoginResult m_LoginResult;
        private string m_senderName;
        private string m_recipientName;
        private DateTime m_dateSent;
        private readonly string m_message;
        private List<string> m_attachments;

        public GreetingCard(FacebookWrapper.LoginResult i_loginResult , string i_recipientName)
        {
            m_LoginResult = i_loginResult;
            m_senderName = i_loginResult.LoggedInUser.Name;
            m_recipientName = i_recipientName;
            m_message = Resources.greeting;
            m_dateSent = DateTime.Now;
            m_attachments = new List<string>();
        }

        public string SenderName { get { return m_senderName; } set { m_senderName = value; } }
        public string RecipientName { get { return m_recipientName; } set { m_recipientName = value; } }
        public DateTime DateSent { get { return m_dateSent; } set { m_dateSent = value; } }
        public string Message { get { return m_message; } }
        public List<string> Attachments { get { return m_attachments; } }


        public void AddAttachment(string attachment)
        {
            m_attachments.Add(attachment);
        }


        public string FormatMessage()
        {
            StringBuilder happyBdayBuilder = new StringBuilder();
            happyBdayBuilder.AppendLine("Dear : " + m_recipientName);
            happyBdayBuilder.AppendLine(Message);
            happyBdayBuilder.AppendLine("From : " + m_senderName);
            return happyBdayBuilder.ToString();
        }



    }
}

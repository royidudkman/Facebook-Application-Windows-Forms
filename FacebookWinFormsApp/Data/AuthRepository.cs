using BasicFacebookFeatures.controllers;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class AppSettings // this class create to access the user make operations like login,logout,post etc...
    {
        public static LoginResult LoginResult { get; set; }
        private long m_AppId;
        private string[] m_RequiredPermissions;
      
        private string AccessToken { get; set; }
        private List<ILoginResultReciver> LoginResultReciver { get; }

        public AppSettings(long i_appId, string[] i_requiredPermissions)
        {
            m_AppId = i_appId;
            m_RequiredPermissions = i_requiredPermissions;
            LoginResultReciver = new List<ILoginResultReciver>();
        }

       
        public long AppId 
        {
            get { return m_AppId; }
            set { m_AppId = value; }
        }
        public string[] RequiredPermissions
        {
            get { return m_RequiredPermissions; }
            set { m_RequiredPermissions = value; }
        }
        
        public void Login()
        {
             LoginResult = FacebookWrapper.FacebookService.Connect("EAAMsl7nPw7gBO2Nij36I44LTHQBpXTBKDf8ZAhMMWU8fcMAbdZB81FEZCMmMZA7kc0w3NIkEBrOnS4jM9furY5NgM63VDCHOeGDdXnaOfLx2W9pYkOLzXyU7nDTjU1wan0lqm6yoPLLoJDsbn4l2yiZBOVN2ZCn8FojO1vF8rY9l9rI1ZCAc3IuqUbTngZDZD");
            //m_LoginResult = FacebookService.Login(m_AppId.ToString(),m_RequiredPermissions);
            //AccessToken = m_LoginResult.AccessToken;
            //LoginResultReciver.Add(new BusinessCardController());
            //LoginResultReciver.Add(new MainForm());
            //NotifyLoggedInUser();
        }

        public void NotifyLoggedInUser()
        {
            foreach(var reciver in LoginResultReciver)
            {
                reciver.OnLogin(LoginResult);
            }
        }

        public void Logout()
        {

        }

    }
}

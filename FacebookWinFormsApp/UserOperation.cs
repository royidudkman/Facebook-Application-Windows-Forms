using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class AppSettings // this class create to access the user make operations like login,logout,post etc...
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        private long m_AppId;
        private string[] m_RequiredPermissions;

        public AppSettings(long i_appId, string[] i_requiredPermissions)
        {
            m_AppId = i_appId;
            m_RequiredPermissions = i_requiredPermissions;
        }

        public FacebookWrapper.LoginResult LoginResult 
        {
            get { return m_LoginResult; }
            set { m_LoginResult = value; }
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
            m_LoginResult = FacebookService.Login(m_AppId.ToString(),m_RequiredPermissions);
        }

        public void Logout()
        {

        }

    }
}

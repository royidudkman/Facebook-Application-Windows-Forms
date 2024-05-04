using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {

        private AppSettings m_AppSettings;
        public LoginForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_AppSettings = new AppSettings(893455099216824, new string[] { "emai", "user_birthday", "user_friends" });
        }


        private void buttonLogin_clicked(object sender, EventArgs e)
        {
            if(m_AppSettings.LoginResult== null)
            {
                m_AppSettings.Login();
            }
        }
    }
}

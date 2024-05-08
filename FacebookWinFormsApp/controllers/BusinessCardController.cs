using BasicFacebookFeatures.Data;
using BasicFacebookFeatures.interfaces;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.controllers
{
    internal class BusinessCardController : ILoginResultReciver
    {
        private BusinessCard BuisnessCard { get; set; }
        private FacebookWrapper.LoginResult LoginResult { get; set; }

        public BusinessCardController()
        {
        }



        public void OnLogin(LoginResult i_LoginResult)
        {
            this.LoginResult = i_LoginResult;
            BuisnessCard = new BusinessCard(LoginResult);

        }
    }
}

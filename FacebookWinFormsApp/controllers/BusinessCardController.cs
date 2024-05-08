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
    internal class BusinessCardController 
    {
        private BusinessCard BusinessCard { get; set; }

        public BusinessCardController()
        {
            BusinessCard = new BusinessCard(AuthRepository.LoginResult);

        }


     
    }
}

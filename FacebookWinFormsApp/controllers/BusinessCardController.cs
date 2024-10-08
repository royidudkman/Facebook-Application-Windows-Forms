﻿using BasicFacebookFeatures.Data;
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
        public UserAbout BusinessCard { get; set; }
        public IFacebookServiceProxy IFacebookService { get; set; }
        public BusinessCardController()
        {
            IFacebookService = new FacebookFetcherService();
            BusinessCard = IFacebookService.FetchAbout();     
        }

        public string GetInfoFromUser(string i_InfoType)
        {
            string retVal;

            switch (i_InfoType)
            {
                case "Name":
                    retVal = BusinessCard.FirstName;
                    break;
                case "Last Name":
                    retVal = BusinessCard.LastName;
                    break;
                case "Location":
                    retVal = BusinessCard.Location?.ToString();
                    break;
                case "Home Town":
                    retVal = BusinessCard.HomeTown?.ToString();
                    break;
                case "Gender":
                    retVal = BusinessCard.Gender?.ToString();
                    break;
                case "Link To Website":
                    retVal = BusinessCard.LinkWebsite;
                    break;
                default:
                    return string.Empty;
            }

            return retVal;
        }
    }
}
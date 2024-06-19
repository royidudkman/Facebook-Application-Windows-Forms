using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Data
{
    internal class AuthRepository
    {
        public static LoginResult LoginResult { get; set; }
        private static long AppId { get; set; }    
        private static string[] RequiredPermissions { get; set; }

        public AuthRepository(long i_AppId, string[] i_RequiredPermissions)
        {
            AppId = i_AppId;
            RequiredPermissions = i_RequiredPermissions;
        }

        public static void Login()
        {      
           // LoginResult = FacebookService.Login(AppId.ToString(), RequiredPermissions);
            LoginResult = FacebookService.Connect("EAAMsl7nPw7gBO8kLMLfyfzkf3RimfQVPBoFFCPixBM9ZANjTqvT0IRWLrFhx4hbEB8ZB4YfhwGYea9ZCE0NeEWfovacB13nVHJAq0iJZAu6UReKR7f5ts7z27tmtiubloeZBhADHltq9jnwf3ZAQRVTUaG6GmSvR3IHAbZB7khzeivseOuNciZBpVueR5AZDZD");
        }

        public static void Logout()
        {
            LoginResult = null;          
        }
    }
}
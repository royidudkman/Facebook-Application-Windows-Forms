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
            //LoginResult = FacebookService.Login(AppId.ToString(), RequiredPermissions);
            LoginResult = FacebookService.Connect("EAAMsl7nPw7gBO6GfKJzCCYbsI8DrgvqvgdMg97CriMpFISK8wAhrAhq0n5tIOIpqsqZBkPc7dZCy2CIfANfWDDafqXuPxCloPwq6O9sVd6zfVwzrp00yAtA0RIcTvi0MBIOs40sYQa47zMvGhMBSpJZC2V9t5DBg9j3sQ8VsrOHhU2VDbNyCi7tkgZDZD");
        }

        public static void Logout()
        {
            LoginResult = null;          
        }
    }
}
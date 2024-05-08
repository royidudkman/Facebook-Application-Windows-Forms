using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.interfaces
{
    internal interface ILoginResultReciver
    {

        void OnLogin(FacebookWrapper.LoginResult i_LoginResult);

    }
}

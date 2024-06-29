using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.interfaces
{
    public interface IUserCardsFetcher
    {
        Control[] GetFriendsCards();
        Control[] GetLikedPagesCards();
        Control[] GetTeamsCards();
        
    }
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Data
{
    internal class UserPhoto : Photo
    {
        public Photo Photo { get; set; }

        public override string ToString()
        {
           return Photo.Name;
        }
    }
}

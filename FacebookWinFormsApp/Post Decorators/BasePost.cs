using BasicFacebookFeatures.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Post_Decorators
{
    internal abstract class BasePost : IPostable
    {
        private IPostable m_Postable;
        public BasePost(IPostable i_Postable)
        {
            m_Postable = i_Postable;
        }

        abstract public void AddDecoratorToPanel(FlowLayoutPanel i_FlowLayoutPanel); 
    }
}
using BasicFacebookFeatures.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    public abstract class BaseTabController : IPopulateable
    {
        protected FlowLayoutPanel FlowLayoutPanel { get; set; }

        public BaseTabController(FlowLayoutPanel flowLayoutPanel)
        {
            FlowLayoutPanel = flowLayoutPanel;
        }

        public abstract void Populate();
    }
}
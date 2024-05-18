using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    public interface ITabController
    {
        void Initialize();
        void Populate();
    }
    public abstract class BaseTabController : ITabController
    {
        protected FlowLayoutPanel FlowLayoutPanel { get; set; }

        public BaseTabController(FlowLayoutPanel flowLayoutPanel)
        {
            FlowLayoutPanel = flowLayoutPanel;
        }

        public abstract void Initialize();
        public abstract void Populate();
    }
}

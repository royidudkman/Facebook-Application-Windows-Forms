using BasicFacebookFeatures.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Post_Decorators
{
    internal class PostText : IPostable
    {
        public RichTextBox RichTextBox = new RichTextBox();

        public void AddDecoratorToPanel(FlowLayoutPanel i_flowLayoutPanel)
        {
            RichTextBox.Width = i_flowLayoutPanel.Width;
            i_flowLayoutPanel.Controls.Add(RichTextBox);
        }
    }
}

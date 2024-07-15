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

        public void AddDecoratorToPanel(FlowLayoutPanel i_FlowLayoutPanel)
        {
            RichTextBox.Width = i_FlowLayoutPanel.Width;
            i_FlowLayoutPanel.Controls.Add(RichTextBox);
        }
    }
}
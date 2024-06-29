using BasicFacebookFeatures.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Post_Decorators
{
    internal class BackgroundDecorator : BasePost
    {
        public Color BackgroundColor { get; set; }
        public BackgroundDecorator(IPostable i_Postable) : base(i_Postable)
        {
            setBackgroundColor();
        }

        private void setBackgroundColor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    BackgroundColor = colorDialog.Color;
                }
                else
                {
                    BackgroundColor = Color.White;
                }
            }
        }

        public override void AddDecoratorToPanel(FlowLayoutPanel i_flowLayoutPanel)
        {
            i_flowLayoutPanel.BackColor = BackgroundColor;
        }
    }
}

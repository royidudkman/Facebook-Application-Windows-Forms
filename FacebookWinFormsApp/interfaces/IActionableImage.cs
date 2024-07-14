using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.interfaces
{
    public interface IActionableImage
    {
        PictureBox GetImage();
        void ToggleCheckBox();
        bool IsChecked();
        void OpenImageItem();
    }
}
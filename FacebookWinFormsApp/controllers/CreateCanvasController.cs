using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicFacebookFeatures.Data.Enums;

namespace BasicFacebookFeatures.controllers
{
    internal class CreateCanvasController : AlbumController
    {
        public int LayoutRaws { get; set; }
        public int LayoutCols { get; set; }
        public eLayoutSize LayoutSize { get; set; }

        public CreateCanvasController()
        {
            LayoutRaws = 0;
            LayoutCols = 0;
        }

        public int IndexUserImages
        {
            get { return LayoutRaws; }
            set
            {
                if (value > UserPhotos.Count || value < 0)
                {
                    value = 0;
                }

                LayoutRaws = value;
            }
        }
    }
}
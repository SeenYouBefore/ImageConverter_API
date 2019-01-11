using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgResizer
{
    interface IResizeStrategy
    {
        void Implement(Bitmap image, string destination, int destW, int destH);
        void Implement(Bitmap image, string destination, int width, int height, int pointerX, int pointerY);
    }
}

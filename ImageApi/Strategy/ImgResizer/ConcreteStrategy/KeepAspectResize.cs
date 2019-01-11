using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgResizer
{
    class KeepAspectResize : IResizeStrategy
    {
        public void Implement(Bitmap image, string destination, int width, int height, int pointerX, int pointerY)
        {
            throw new NotImplementedException();
        }

        public void Implement(Bitmap bmp, string destination, int destW, int destH)
        {
            if (bmp.Width > bmp.Height)
            {
                destH = destW * (bmp.Width / bmp.Height);
            }
            else
            {
                destH = destW * (bmp.Height / bmp.Width);
            }

            Bitmap newImage = new Bitmap(bmp, destW, destH);
            newImage.Save(destination, ImageFormat.Jpeg);
        }
    }
}

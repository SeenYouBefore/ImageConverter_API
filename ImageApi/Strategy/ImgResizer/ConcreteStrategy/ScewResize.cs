using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgResizer
{
    class ScewResize : IResizeStrategy
    {
        public void Implement(Bitmap bmp, string destination, int destW, int destH)
        {
            try
            {
                Bitmap newImage = new Bitmap(bmp, destW, destH);
                newImage.Save(destination);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't Scew Image!");
            }
        }

        public void Implement(Bitmap image, string destination, int width, int height, int pointerX, int pointerY)
        {
            throw new NotImplementedException();
        }
    }
}

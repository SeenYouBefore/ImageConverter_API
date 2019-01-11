using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgResizer
{
    class CropResize : IResizeStrategy
    {
        public void Implement(Bitmap image, string destination, int width, int height, int pointerX, int pointerY)
        {
            try
            {
                Rectangle srcRectangle = new Rectangle(pointerX, pointerY, width, height);
                using (Graphics g = Graphics.FromImage(image))
                {
                    g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), srcRectangle, GraphicsUnit.Pixel);
                    image.Save(destination);
                }
            }
            catch (Exception)
            {
                throw new Exception("Couldn't Crop Image!");
            }
        }

        public void Implement(Bitmap image, string destination, int destW, int destH)
        {
            throw new NotImplementedException();
        }
    }
}
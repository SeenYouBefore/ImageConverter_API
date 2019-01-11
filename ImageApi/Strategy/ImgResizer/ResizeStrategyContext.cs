using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgResizer
{
    class ResizeStrategyContext
    {
        IResizeStrategy strategy;
        //here we use the strategies
        public ResizeStrategyContext(IResizeStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Resize(Image image, string destination, int destW, int destH)
        {
            Bitmap bmp = new Bitmap(image);
            try
            {
                strategy.Implement(bmp, destination, destW, destH);

            }
            catch (Exception)
            {

                throw new Exception(bmp + " "+destination+" "+ destW+ ""+ destH);
            }
        }

        public void Resize(Image image, string destination, int width, int height, int pointerX, int pointerY)
        {
            Bitmap bmp = new Bitmap(image);
            strategy.Implement(bmp, destination, width, height, pointerX, pointerY);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgConverter
{
    class ConvertToPng : IConvertStrategy
    {
        public void Implement(System.Drawing.Image image, string destination)
        {
            try
            {
                image.Save(destination, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
                throw new Exception("Couldn't convert to Png!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgConverter
{
    class ConvertToJpeg : IConvertStrategy
    {
        public void Implement(Image image, string destination)
        {
            try
            {
                image.Save(destination, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
                throw new Exception("Couldn't convert to Jpeg!");
            }
        }
    }
}

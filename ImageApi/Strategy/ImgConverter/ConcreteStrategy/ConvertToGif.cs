using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy.ImgConverter
{
    class ConvertToGif : IConvertStrategy
    {
        public void Implement(Image image,string destination)
        {
            try
            {
                image.Save(destination, System.Drawing.Imaging.ImageFormat.Gif);
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
                throw new Exception("Couldn't convert to Gif!");
            }
        }
    }
}

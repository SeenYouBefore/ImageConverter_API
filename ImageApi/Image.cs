using ImageApi.Strategy;
using ImageApi.Strategy.ImgConverter;
using ImageApi.Strategy.ImgResizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi
{
    public class Image
    {
        public void Convert(string source, string destination, string type)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(source);
            
            StrategyContext context;
            switch (type.ToLower())
            {
                case "jpeg":
                case "jpg":
                    context = new StrategyContext(new ConvertToJpeg());
                    break;
                case "gif":
                    context = new StrategyContext(new ConvertToGif());
                    break;
                case "png":
                    context = new StrategyContext(new ConvertToPng());
                    break;
                default:
                    throw new Exception("Wrong file format chosen!");
            }

            context.ConvertImage(image, destination);
        }

        public void Resize(string source,string destination, string operation, int destW, int destH, int pointerX, int pointerY)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(source);
            
            ResizeStrategyContext context;
            switch (operation.ToLower())
            {
                case "scew":
                    context = new ResizeStrategyContext(new ScewResize());
                    context.Resize(image, destination, destW, destH);
                    break;
                case "keepaspect":
                    context = new ResizeStrategyContext(new KeepAspectResize());
                    context.Resize(image, destination, destW, destH);
                    break;
                case "crop":
                    context = new ResizeStrategyContext(new CropResize());
                    context.Resize(image, destination, destW, destH, pointerX, pointerY);
                    break;
                default:
                    throw new Exception("Wrong file format chosen!");
            }
            
        }

    }
}

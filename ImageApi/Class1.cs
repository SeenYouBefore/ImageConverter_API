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
    public class Class1
    {
        public void Convert(string source, string destination, string type)
        {
            //byte[] img_bytes = File.ReadAllBytes(source); //read img file into memory
            //MemoryStream img_ms = new MemoryStream(img_bytes);
            //Image img = Image.FromStream(img_ms);


            //MemoryStream save_ms = new MemoryStream();
            //((Bitmap)img).Save(save_ms, ImageFormat.Jpeg);
            //byte[] resaved_img = save_ms.ToByteArray();

            //create object from source file
            Image image = Image.FromFile(source);

            //implement context strategy from context using IMG object instead of source...
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
            Image image = Image.FromFile(source);

            //implement context strategy from context using IMG object instead of source...
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

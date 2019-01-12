using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi.Strategy
{
    interface IConvertStrategy
    {
        void Implement(System.Drawing.Image image, string destination);
    }
}

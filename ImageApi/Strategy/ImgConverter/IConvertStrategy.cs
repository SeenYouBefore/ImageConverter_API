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
        void Implement(Image image, string destination);
    }
}

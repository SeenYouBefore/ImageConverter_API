using ImageApi.Strategy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApi
{
    class StrategyContext
    {
        IConvertStrategy strategy;
        //here we use the strategies
        public StrategyContext(IConvertStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ConvertImage(Image image, string destination)
        {
            strategy.Implement(image, destination);
        }
    }
}

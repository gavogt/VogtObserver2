using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class MSFT : Stock
    {
        private double _msftPrice;
        public double setMSFTPrice(double newMSFTPrice)
        {
            _msftPrice = newMSFTPrice;
            Notify();

            return _msftPrice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class MSFT : Stock
    {
        private double _msftPrice;

        public double SetMSFTPrice(double newMSFTPrice)
        {
            _msftPrice = newMSFTPrice;
            Notify();

            return _msftPrice;
        }
    }
}

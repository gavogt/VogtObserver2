using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class GOOG : Stock
    {
        private double _googPrice;

        public double SetGoogPrice(double newGoogPrice)
        {
            _googPrice = newGoogPrice;
            Notify();

            return _googPrice;
        }
    }
}

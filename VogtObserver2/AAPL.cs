using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class AAPL : Stock
    {
        private double _aaplPrice;

        public double setAAPLPrice(double newAAPLPrice)
        {
            _aaplPrice = newAAPLPrice;
            Notify();

            return _aaplPrice;
        }
    }
}

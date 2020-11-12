using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    interface IObserver
    {
        public void Update(double temp, string symbol);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    interface IObservable
    {
        public void AddObserver(IObserver o);
        public void RemoveObserver(IObserver o);
    }
}

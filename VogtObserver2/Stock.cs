using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class Stock : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private int _random;

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public int GetRandomInt()
        {
            Random random = new Random();
            _random = random.Next(1, 1000);

            return _random;
        }
    }
}

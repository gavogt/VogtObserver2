using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class Stock : IObservable
    {
        private HistoricalDataInfo _hdi = new HistoricalDataInfo();
        private List<HistoricalDataResponse> _hdr;

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

        public double GetAAPLPrice()
        {
             double temp = 0.0;
            _hdr = _hdi.HistoricalData("https://sandbox.iexapis.com/stable/stock/AAPL/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e");

            foreach (var historicaldata in _hdr)
            {
                temp = historicaldata.latestPrice;
            }

            return temp;
        }

        public double GetMSFTPrice()
        {
            double temp = 0.0;
            _hdr = _hdi.HistoricalData("https://sandbox.iexapis.com/stable/stock/MSFT/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e");

            foreach (var historicaldata in _hdr)
            {
                temp = historicaldata.latestPrice;
            }

            return temp;
        }

        public double GetGOOGPrice()
        {
            double temp = 0.0;
            _hdr = _hdi.HistoricalData("https://sandbox.iexapis.com/stable/stock/GOOG/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e");

            foreach (var historicaldata in _hdr)
            {
                temp = historicaldata.latestPrice;
            }

            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class StockGrabber : IObservable
    {
        private HistoricalDataInfo _hdi = new HistoricalDataInfo();
        private List<HistoricalDataResponse> _hdr;

        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(GetPrice(), GetStockName()); 
            }
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public double GetPrice()
        {
            
            var temp = 0.0;

            _hdr = _hdi.HistoricalData($"https://sandbox.iexapis.com/stable/stock/{GetStockName()}/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e");

            foreach (var historicaldata in _hdr)
            {
                temp = historicaldata.latestPrice;
            }


            return temp;
        }

        public string GetStockName() {

            string[] tempSymbols = new string[3] { "GOOG", "MSFT", "AAPL" };
            string symbol = " ";

            Random random = new Random();

            int temp;

            for (int i = 0; i < 200; i++)
            {
                temp = random.Next(0, 3);
                symbol = tempSymbols[temp];
            }

            return symbol;
        }
    }
}

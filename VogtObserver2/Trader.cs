using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class Trader : IObserver
    {
        private StockGrabber _stockgrabber = new StockGrabber();
        private StockGrabber _stockgrabber2 = new StockGrabber();
        private StockGrabber _stockgrabber3 = new StockGrabber();

        private string _name;

        Random rand = new Random();

        private string[] _buyOrSell = new string[] { " ", "buy", "sell" };

        public Trader(StockGrabber stockgrabber, string name, string symbol)
        {
            _stockgrabber = stockgrabber;
            _name = name;

        }

        public void Update(double cost, string symbol)
        {
            Console.WriteLine($"The Lastest trade is Trader: {_name} {_buyOrSell[rand.Next(1, 3)]} cost {cost:C2} Stock: {symbol}");
        }

        public void PrintPrices()
        {


        }
    }
}

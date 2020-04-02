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

        private double _msftPrice;
        private double _googPrice;
        private double _aaplPrice;

        private string _name;

        Random rand = new Random();

        private string[] _buyOrSell = new string[] { " ", "buy", "sell" };

        public Trader(StockGrabber stockgrabber, string name)
        {
            _stockgrabber = stockgrabber;
            _name = name;

        }

        public void Update(double cost)
        {
            Console.WriteLine($"The Lastest trade is Trader: {_name} {_buyOrSell[rand.Next(1, 3)]} cost {cost:C2} Stock: MSFT");
        }

        public void PrintPrices()
        {


        }
    }
}

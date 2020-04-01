using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class Trader : IObserver
    {
        private Stock _stockgrabber = new Stock();

        private double _msftPrice;
        private double _googPrice;
        private double _aaplPrice;

        private MSFT _msft = new MSFT();
        private GOOG _goog = new GOOG();
        private AAPL _aapl = new AAPL();

        private string _name;

        Random rand = new Random();

        private string[] _buyOrSell = new string[] { " ", "buy", "sell" };

        public Trader(Stock stockgrabber, string name)
        {
            _stockgrabber = stockgrabber;
            _stockgrabber.AddObserver(this);
            _name = name;

        }

        public void Update()
        {
            _msftPrice = (_msft.setMSFTPrice(_stockgrabber.GetAAPLPrice()));
            _googPrice = (_goog.setGoogPrice(_stockgrabber.GetMSFTPrice()));
            _aaplPrice = (_aapl.setAAPLPrice(_stockgrabber.GetGOOGPrice()));
        }

        public void PrintPrices()
        {

            Console.WriteLine($"The Lastest trade is Trader: {_name} {_buyOrSell[rand.Next(1, 3)]} cost {_msftPrice} Stock: MSFT");
            Console.WriteLine($"The Lastest trade is Trader: {_name} {_buyOrSell[rand.Next(1, 3)]} cost {_googPrice} Stock: GOOG");
            Console.WriteLine($"The Lastest trade is Trader: {_name} {_buyOrSell[rand.Next(1, 3)]} cost {_aaplPrice} Stock: AAPL");

        }
    }
}

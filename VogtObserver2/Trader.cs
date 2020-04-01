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

        private string[] _buyOrSell = new string[] { "buy", "sell" };

        public Trader(Stock stockgrabber)
        {
            _stockgrabber = stockgrabber;
            _stockgrabber.AddObserver(this);

        }      

        public void Update()
        {
            _msftPrice = (_msft.setMSFTPrice(_stockgrabber.GetRandomInt()));
            _googPrice = _stockgrabber.GetRandomInt();
            _aaplPrice = _stockgrabber.GetRandomInt();
        }

        public void PrintPrices()
        {
            Console.WriteLine($"The Lastest trade is Trader: Julie sell cost {_msftPrice} Stock: MSFT");
            Console.WriteLine($"The Lastest trade is Trader: Julie sell cost {_googPrice} Stock: GOOG");
            Console.WriteLine($"The Lastest trade is Trader: Julie sell cost {_aaplPrice} Stock: AAPL");
        }
    }
}

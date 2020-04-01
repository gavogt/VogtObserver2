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

        private string[] _buyOrSell = new string[] { "buy", "sell" };

        public Trader(Stock stockgrabber)
        {
            _stockgrabber = stockgrabber;
            _stockgrabber.AddObserver(this);

        }      

        public void Update()
        {
            _msftPrice = (_msft.setMSFTPrice(_stockgrabber.GetRandomInt()));
            _googPrice = (_goog.setGoogPrice(_stockgrabber.GetRandomInt()));
            _aaplPrice = (_aapl.setAAPLPrice( _stockgrabber.GetRandomInt()));
        }

        public void PrintPrices()
        {
            /*
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"The Lastest trade is Trader: Julie {_buyOrSell[i]} cost {_msftPrice} Stock: MSFT");
            }
            */
            Console.WriteLine($"The Lastest trade is Trader: Julie sell cost {_msftPrice} Stock: MSFT");
            Console.WriteLine($"The Lastest trade is Trader: Julie sell cost {_googPrice} Stock: GOOG");
            Console.WriteLine($"The Lastest trade is Trader: Julie sell cost {_aaplPrice} Stock: AAPL");
        }
    }
}

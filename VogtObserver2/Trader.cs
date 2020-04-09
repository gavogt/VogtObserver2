using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class Trader : IObserver
    {
        private string _name;

        private Random _rand = new Random();

        private string[] _buyOrSell = new string[] { " ", "buy", "sell" };

        public Trader(string name)
        {

            _name = name;

        }

        public void Update(double cost, string symbol)
        {
            Console.WriteLine($"The Lastest trade is Trader: {_name} {_buyOrSell[_rand.Next(1, 3)]} cost {cost:C2} Stock: {symbol}");
        }

        public void PrintPrices()
        {


        }
    }
}

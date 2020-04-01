using System;
using System.Threading;

namespace VogtObserver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stockGrabber = new Stock();

            Run(stockGrabber);
        }

        public static void Run(Stock stockGrabber)
        {

            Trader t1 = new Trader(stockGrabber, "Julie");
            Trader t2 = new Trader(stockGrabber, "Amy");
            Trader t3 = new Trader(stockGrabber, "Mark");

            for (int i = 0; i <= 20; i++)
            {
                t1.Update();
                t1.PrintPrices();

                t2.Update();
                t2.PrintPrices();

                t3.Update();
                t3.PrintPrices();

                Thread.Sleep(2000);

            }



        }
    }
}

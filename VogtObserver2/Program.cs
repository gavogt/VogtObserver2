using System;
using System.Collections.Generic;
using System.Threading;

namespace VogtObserver2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Run();
        }

        public static void Run()
        {
            StockGrabber stockGrabber = new StockGrabber();

            Trader t1 = new Trader(stockGrabber, "Julie","MSFT");
            Trader t2 = new Trader(stockGrabber, "Amy","APPL");
            Trader t3 = new Trader(stockGrabber, "Mark","GOOG");

            stockGrabber.AddObserver(t1);
            stockGrabber.AddObserver(t2);
            stockGrabber.AddObserver(t3);


            for (int i = 0; i <= 5; i++)
            {

                stockGrabber.Notify();

                Thread.Sleep(2000);

            }
        }
    }
}

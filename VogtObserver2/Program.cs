using System;

namespace VogtObserver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stockGrabber = new Stock();
            MSFT msft = new MSFT();

            Run(stockGrabber, msft);
        }

        public static void Run(Stock stockGrabber,MSFT msft)
        {
       
            Trader julie = new Trader(stockGrabber);
            msft.setMSFTPrice(666);

            julie.Update();
            julie.PrintPrices();
        }
    }
}

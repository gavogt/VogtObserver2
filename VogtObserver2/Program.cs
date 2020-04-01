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
            /*
            AlphaVantageData avd = new AlphaVantageData();
            avd.MonthlyPrices();
            Console.WriteLine(avd.High);
            Console.WriteLine(avd.Low);
            Console.WriteLine(avd.Open);
            Console.WriteLine(avd.Timestamp);
            Console.WriteLine(avd.Volume);
            Console.WriteLine(avd.Close);
            */
              
            HistoricalDataResponse hdr = new HistoricalDataResponse();
            HistoricalDataInfo hdi = new HistoricalDataInfo();
            HistoricalDataInfo.HistoricalData();

            var close = hdr.close;
            Console.WriteLine($"{close}");
            var open = hdr.open;
            Console.WriteLine($"{open}");

            /*
            var high = hdr.high;
            Console.WriteLine($"{high}");
            var low = hdr.low;
            Console.WriteLine($"{low}");
            var date = hdr.date;
            Console.WriteLine($"{date}");
            var volume = hdr.volume;
            Console.WriteLine($"{volume}");
            var unadjustedVolume = hdr.unadjustedVolume;
            Console.WriteLine($"{unadjustedVolume}");
            var change = hdr.change;
            Console.WriteLine($"{change}");
            var changePercent = hdr.changePercent;
            Console.WriteLine($"{changePercent}");
            var vwap = hdr.vwap;
            Console.WriteLine($"{vwap}");
            var label = hdr.label;
            Console.WriteLine($"{label}");
            var changeOverTime = hdr.changeOverTime;
            Console.WriteLine($"{changeOverTime}");
            */
            /*
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

           }*/



        }
    }
}

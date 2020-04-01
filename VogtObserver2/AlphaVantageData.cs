using ServiceStack;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VogtObserver2
{
    class AlphaVantageData
    {
        public DateTime Timestamp { get; set; }
        public decimal Open { get; set; }

        public decimal High { get; set; }
        public decimal Low { get; set; }

        public decimal Close { get; set; }
        public decimal Volume { get; set; }

        public void MonthlyPrices()
        {
            // retrieve monthly prices for Microsoft
            var symbol = "MSFT";
            var apiKey = "demo"; // retrieve your api key from https://www.alphavantage.co/support/#api-key
            var monthlyPrices = $"https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol={symbol}&apikey={apiKey}&datatype=csv"
                            .GetStringFromUrl().FromCsv<List<AlphaVantageData>>();

            monthlyPrices.PrintDump();

            // some simple stats
            var maxPrice = monthlyPrices.Max(u => u.Close);
            var minPrice = monthlyPrices.Min(u => u.Close);
        }
    }



}

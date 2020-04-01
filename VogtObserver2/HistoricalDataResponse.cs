using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class HistoricalDataResponse
    {

        public double open { get; set; }
        public double close { get; set; }
        public int volume { get; set; }
        public int unadjustedVolume { get; set; }
        public double change { get; set; }
        public double changePercent { get; set; }
        public double vwap { get; set; }
        public string label { get; set; }
        public double changeOverTime { get; set; }

        public string latestPrice { get; set; }

        public double iexRealtimePrice { get; set; }

    }
}

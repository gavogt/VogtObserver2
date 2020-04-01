using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver2
{
    class HistoricalDataManager
    {     
        private List<HistoricalDataResponse> _hdr;

        public HistoricalDataManager(List<HistoricalDataResponse> hdr)
        {
            _hdr = hdr;
            LoopThroughHistoricalData();
        }

        public void LoopThroughHistoricalData()
        {
            foreach (var historicaldata in _hdr)
            {
                Console.WriteLine($"Latest Price: {historicaldata.latestPrice}");

            }
        }
        
    }
}

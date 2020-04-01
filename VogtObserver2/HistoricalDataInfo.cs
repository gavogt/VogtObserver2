using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace VogtObserver2
{
    class HistoricalDataInfo
    {
        public static void HistoricalData()
        {
            var symbol = "msft";
            var IEXTrading_API_PATH = "https://api.iextrading.com/1.0/stock/{0}/chart/1y";

            IEXTrading_API_PATH = string.Format(IEXTrading_API_PATH, symbol);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                //For IP-API
                client.BaseAddress = new Uri(IEXTrading_API_PATH);

                HttpResponseMessage response = client.GetAsync(IEXTrading_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    var historialDataList = response.Content.ReadAsAsync<List<HistoricalDataResponse>>().GetAwaiter().GetResult();

                    foreach (var historicalData in historialDataList)
                    {
                        if (historicalData != null)
                        {
                            Console.WriteLine("Open: " + historicalData.open);
                            Console.WriteLine("Close: " + historicalData.close);
                            Console.WriteLine("Low: " + historicalData.low);
                            Console.WriteLine("High: " + historicalData.high);
                            Console.WriteLine("Change: " + historicalData.change);
                            Console.WriteLine("Change Percentage: " + historicalData.changePercent);
                        }
                    }
                }
            }
        }
    }
}

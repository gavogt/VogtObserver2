using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ServiceStack;
using ServiceStack.Text;
using System.Linq;
using RestSharp.Serializers.NewtonsoftJson;
using RestSharp.Serialization.Json;
using RestSharp;

namespace VogtObserver2
{
    class HistoricalDataInfo
    {
        public static void HistoricalData()
        {
            HistoricalDataResponse hdr = new HistoricalDataResponse();
            var symbol = "msft";
            var IEXTrading_API_PATH = "https://sandbox.iexapis.com/stable/stock/IBM/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e";

            var client = new RestClient("https://sandbox.iexapis.com/stable/stock/IBM/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e");

            var request = new RestRequest(IEXTrading_API_PATH, Method.GET);

            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();

            List<HistoricalDataResponse> output = deserialize.Deserialize<List<HistoricalDataResponse>>(response);
            output.PrintDump();


            foreach (var historicalData in output)
            {
                if (historicalData != null)
                {
                    Console.WriteLine(hdr.latestPrice = historicalData.latestPrice);
                    Console.WriteLine($"HDR latest price {hdr.latestPrice}");
                    Console.WriteLine("Open: " + historicalData.open);
                    Console.WriteLine("Close: " + historicalData.close);
                    Console.WriteLine("Lastest aaprice: "+historicalData.latestPrice);
                    //Console.WriteLine("Low: " + historicalData.low);
                    //Console.WriteLine("High: " + historicalData.high);
                    Console.WriteLine("Change: " + historicalData.change);
                    Console.WriteLine("Change Percentage: " + historicalData.changePercent);
                }
            }
        }
    }
}

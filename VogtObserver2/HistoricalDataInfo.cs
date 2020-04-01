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
            var symbol = "msft";
            var IEXTrading_API_PATH = "https://sandbox.iexapis.com/stable/stock/IBM/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e";

            var client = new RestClient("https://sandbox.iexapis.com/stable/stock/IBM/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e");

            var request = new RestRequest(IEXTrading_API_PATH, Method.GET);

            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();

            var output = deserialize.Deserialize<List<HistoricalDataResponse>>(response);
            output.PrintDump();



            //IEXTrading_API_PATH = string.Format(IEXTrading_API_PATH, symbol);
            /*
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                //For IP-API
                client.BaseAddress = new Uri(IEXTrading_API_PATH);

                HttpResponseMessage response = client.GetAsync(IEXTrading_API_PATH).GetAwaiter().GetResult();
                
                Console.ReadLine();
                var deserialize = new JsonDeserializer();
                deserialize.Deserialize<List<HistoricalDataResponse>>(response);

                //response.PrintDump();
                //client.UseNewtonsoftJson();

                if (response.IsSuccessStatusCode)
                {
                    var historialDataList = response.Content.ReadAsAsync<List<HistoricalDataResponse>>().GetAwaiter().GetResult();
                }
                else { Console.WriteLine("Error!"); }
                
                /*
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
            }*/
        }
    }
}

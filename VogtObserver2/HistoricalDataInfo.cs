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
using System.Net;

namespace VogtObserver2
{
    class HistoricalDataInfo
    {

        public List<HistoricalDataResponse> HistoricalData(string path)
        {

            var client = new RestClient("https://sandbox.iexapis.com/stable/stock/IBM/quote?token=Tpk_81485eef3d7041e6bd05ba956b85fa4e");

            var request = new RestRequest(path, Method.GET);

            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();

            var output = deserialize.Deserialize<List<HistoricalDataResponse>>(response);

            return output;
        }
     
    }
}

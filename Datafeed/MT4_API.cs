using Datafeed.Models;
using Newtonsoft.Json.Linq;
using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace Datafeed
{
    public static class MT4_API
    {
        private static readonly Uri _BaseAddress = new Uri("https://mt4.mtapi.io");

        //private const int _User = 1737931;
        //private const string _Password = "pi4twul";
        //private const string _Host = "188.165.206.46";
        //private const int _Port = 444;

        private static HttpClient GetHttpClient()
        {
            string proxyURL = @"http://83.217.23.35:8090";
            WebProxy webProxy = new WebProxy(proxyURL);

            HttpClientHandler httpClientHandler = new HttpClientHandler
            {
                Proxy = webProxy
            };
            HttpClient client = new HttpClient(httpClientHandler);

            return client;
        }

        public static string GetToken(string user, string password, string host, int port)
        {
            using (var client = GetHttpClient())
            {
                //HttpResponseMessage response = client.GetAsync("https://httpbin.org/ip").Result;
                //string responseContent = response.Content.ReadAsStringAsync().Result;

                client.BaseAddress = _BaseAddress;
                var urlConnect = string.Format($"Connect?user={user}&password={password}&host={host}&port={port}&connectTimeoutSeconds=30");
                var responseConnectResult = client.GetAsync(urlConnect).Result;
                if(responseConnectResult.StatusCode == HttpStatusCode.OK)
                    return responseConnectResult.Content.ReadAsStringAsync().Result;

                return null;
            }
        }

        public static List<Symbol> LoadSymbols(string token)
        {
            using (var client = GetHttpClient())
            {
                client.BaseAddress = _BaseAddress;

                //SymbolList
                var urlSymbolList = string.Format($"SymbolList?id={token}");
                var responseSymbolList = client.GetAsync(urlSymbolList).Result;
                var quoteHistoryResult = responseSymbolList.Content.ReadAsStringAsync().Result;

                var symbolArray = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(quoteHistoryResult);

                //SymbolParamsMany
                var urlSymbolParamsMany = string.Format($"SymbolParamsMany?id={token}&symbol={string.Join("&symbol=", symbolArray)}");
                var responseSymbolParamsMany = client.GetAsync(urlSymbolParamsMany).Result;
                var symbolParamsManyResult = responseSymbolParamsMany.Content.ReadAsStringAsync().Result;

                var result = new List<Symbol>();

                JArray arraySymbolParams = JArray.Parse(symbolParamsManyResult);
                foreach (JObject item in arraySymbolParams)
                {
                    var symbol = new Symbol();
                    symbol.Name = item["symbolName"].ToString();
                    symbol.Market = item["group"]["name"].ToString();
                    symbol.Description = item["symbol"]["ex"]["description"].ToString();

                    result.Add(symbol);
                }

                return result;
            }
        }

        public static List<BarsForSymbol> GetQuoteHistoryMany(string token, List<Symbol> symbols, string period, int depth)
        {
            var result = new List<BarsForSymbol>();

            if (symbols == null || symbols.Count == 0)
                return result;

            using (var client = GetHttpClient())
            {
                client.BaseAddress = _BaseAddress;

                var urlQuoteHistoryMany = string.Format($"QuoteHistoryMany?id={token}&symbol={string.Join("&symbol=", symbols)}&timeframe={period}&from={DateTime.Now.ToString("yyyy-MM-dd")}T00%3A00%3A00&count={depth}");
                var responseQuoteHistoryMany = client.GetAsync(urlQuoteHistoryMany).Result;
                var quoteHistoryManyResult = responseQuoteHistoryMany.Content.ReadAsStringAsync().Result;

                result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BarsForSymbol>>(quoteHistoryManyResult);

                return result;
            }
        }
    }
}

using Datafeed.Models;
using Newtonsoft.Json.Linq;
using ScreenerLib;
using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private static string _Token;

        private static HttpClient GetHttpClient()
        {
            string proxyURL = @"http://5.189.190.187:8090";
            WebProxy webProxy = new WebProxy(proxyURL);

            HttpClientHandler httpClientHandler = new HttpClientHandler
            {
                //Proxy = webProxy
            };
            HttpClient client = new HttpClient(httpClientHandler);

            return client;
        }

        public static bool Connect(string user, string password, string host, int port)
        {
            using (var client = GetHttpClient())
            {
                //HttpResponseMessage response = client.GetAsync("https://httpbin.org/ip").Result;
                //string responseContent = response.Content.ReadAsStringAsync().Result;

                client.BaseAddress = _BaseAddress;
                var urlConnect = string.Format($"Connect?user={user}&password={password}&host={host}&port={port}&connectTimeoutSeconds=30");
                var responseConnectResult = client.GetAsync(urlConnect).Result;
                if (responseConnectResult.StatusCode == HttpStatusCode.OK)
                {
                    _Token = responseConnectResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
                else
                    return false;
            }
        }

        public static List<Symbol> LoadSymbols()
        {
            using (var client = GetHttpClient())
            {
                client.BaseAddress = _BaseAddress;

                //SymbolList
                var urlSymbolList = string.Format($"SymbolList?id={_Token}");
                var responseSymbolList = client.GetAsync(urlSymbolList).Result;
                var quoteHistoryResult = responseSymbolList.Content.ReadAsStringAsync().Result;

                var symbolArray = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(quoteHistoryResult);

                //SymbolParamsMany
                var urlSymbolParamsMany = string.Format($"SymbolParamsMany?id={_Token}&symbol={string.Join("&symbol=", symbolArray)}");
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

        public static List<BarsCollection> GetQuoteHistoryMany(List<string> symbols, string period, int depth)
        {
            var result = new List<BarsCollection>();

            if (symbols == null || symbols.Count == 0)
                return result;

            using (var client = GetHttpClient())
            {
                client.BaseAddress = _BaseAddress;

                //var urlQuoteHistoryMany = string.Format($"QuoteHistoryMany?id={_Token}&symbol={string.Join("&symbol=", symbols)}&timeframe={period}&from={DateTime.Now.ToString("yyyy-MM-dd")}T00%3A00%3A00&count={depth}");
                var urlQuoteHistoryMany = string.Format($"QuoteHistoryMany?id={_Token}&symbol={string.Join("&symbol=", symbols)}&timeframe={period}&from={DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}&count={depth}");
                var responseQuoteHistoryMany = client.GetAsync(urlQuoteHistoryMany).Result;
                var quoteHistoryManyResult = responseQuoteHistoryMany.Content.ReadAsStringAsync().Result;

                var history = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BarsForSymbol>>(quoteHistoryManyResult);

                // parse
                foreach(var item in history)
                {
                    var barsCollection = new BarsCollection();
                    barsCollection.SymbolName = item.SymbolName;
                    barsCollection.Period = period;
                    barsCollection.Bars = new List<ScreenerLib.Models.Bar>();
                    foreach (var bar in item.Bars)
                    {
                        var b = new ScreenerLib.Models.Bar();
                        b.Time = bar.Time;
                        b.Open = bar.Open;
                        b.High = bar.High;
                        b.Low = bar.Low;
                        b.Close = bar.Close;
                        b.Volume = bar.Volume;
                        barsCollection.Bars.Add(b);
                    }

                    result.Add(barsCollection);
                }

                return result;
            }
        }

        public static List<BarsCollection> GetQuoteHistory(List<Security> securities)
        {
            var reconSymbols = new List<string>();
            var historyCollection = new List<BarsCollection>();


            foreach (var period in Period.GetPeriods())
            {
                var symbols = securities.Where(w => w.Periods.Any(a => a == period)).Select(s => s.SymbolName).ToList();

                if(symbols.Count == 0)
                {
                    //load this period if exists symbols in reconSymbols
                    if (reconSymbols.Count > 0)
                    {
                        var reconHistory = GetQuoteHistoryMany(reconSymbols, period, 7);
                        historyCollection.AddRange(reconHistory);
                    }

                    continue;
                }

                var history = GetQuoteHistoryMany(symbols, period, 30);
                historyCollection.AddRange(history);


                //load this period if exists symbols in reconSymbols
                var reconSymbs = reconSymbols.Except(symbols).ToList();
                if (reconSymbs.Count > 0)
                {
                    var reconHistory = GetQuoteHistoryMany(reconSymbs, period, 7);
                    historyCollection.AddRange(reconHistory);
                }

                //add symbols to load history for reconstruct
                reconSymbols.AddRange(symbols.Except(reconSymbols));
            }

            //return historyCollection; //!!!

            //reconstruct last bar
            var result = new List<BarsCollection>();

            foreach (var period in Period.GetPeriods())
            {
                var symbols = securities.Where(w => w.Periods.Any(a => a == period)).Select(s => s.SymbolName).ToList();

                if (symbols.Count == 0)
                    continue;

                foreach (var symbol in symbols)
                {
                    var history = historyCollection.Single(w => w.SymbolName == symbol && w.Period == period);

                    var reconBar = RecontructLastBar(history.Bars.Max(m => m.Time),
                                                       period,
                                                       historyCollection.Where(w => w.SymbolName == symbol).ToList());
                    if (reconBar != null)
                        history.Bars.Add(reconBar);

                    result.Add(history);
                }

            }

            return result;
        }

        private static ScreenerLib.Models.Bar RecontructLastBar(DateTime timePrevBar, string period, List<BarsCollection> bars)
        {
            string[] periods = Period.GetPeriodsLessThen(period);
            if (periods == null)
                return null;

            var bar = new ScreenerLib.Models.Bar();

            if (period == "MN1")
                bar.Time = timePrevBar.AddMonths(1);
            else if (period == "W1")
                bar.Time = timePrevBar.AddDays(7);
            else if (period == "D1")
                bar.Time = timePrevBar.AddDays(1);
            else if (period == "H4")
                bar.Time = timePrevBar.AddHours(4);
            else if (period == "H1")
                bar.Time = timePrevBar.AddHours(1);
            else if (period == "M30")
                bar.Time = timePrevBar.AddMinutes(30);
            else if (period == "M15")
                bar.Time = timePrevBar.AddMinutes(15);
            else if (period == "M5")
                bar.Time = timePrevBar.AddMinutes(5);
            else if (period == "M1")
                bar.Time = timePrevBar.AddMinutes(1);

            var lowerBarsCollections = bars.Where(w => periods.Contains(w.Period)).ToList();
            var lowerBars = lowerBarsCollections.SelectMany(s => s.Bars).Where(w => w.Time >= bar.Time).ToList();
            if (lowerBars.Count == 0)
                return null;

            bar.Open = lowerBars.First(w => w.Time == lowerBars.Min(min => min.Time)).Open;
            bar.High = lowerBars.Max(max => max.High);
            bar.Low = lowerBars.Min(min => min.Low);
            bar.Close = lowerBars.Last(w => w.Time == lowerBars.Max(max => max.Time)).Close;
            bar.Volume = lowerBars.Sum(w => w.Volume);

            return bar;
        }

    }
}

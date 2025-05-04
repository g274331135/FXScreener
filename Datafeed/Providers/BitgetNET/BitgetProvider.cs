using Bitget.Net.Clients;
using Bitget.Net.Enums;
using Datafeed.Providers.BitgetNET.Models;
using Datafeed.Providers.MT4API.Models;
using Newtonsoft.Json.Linq;
using ScreenerLib;
using ScreenerLib.Interfaces;
using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datafeed.Providers.BitgetNET
{
    public class BitgetProvider : IDatafeedProvider
    {
        private BitgetRestClient _Client;

        string IDatafeedProvider.Name => "BitgetNET";

        async Task<bool> IDatafeedProvider.ConnectAsync(string jsonConfig)
        {
            try
            {
                var config = Newtonsoft.Json.JsonConvert.DeserializeObject<BitgetNetConfig>(jsonConfig);

                _Client = new BitgetRestClient();
                _Client.SetApiCredentials(new Bitget.Net.Objects.BitgetApiCredentials(config.Key, config.Secret, config.Passphrase));
                return _Client.FuturesApi.Authenticated;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        async Task<List<Symbol>> IDatafeedProvider.GetAvailableSymbolsAsync()
        {
            var usdtPerpetualSymbols = await _Client.FuturesApi.ExchangeData.GetSymbolsAsync(Bitget.Net.Enums.BitgetProductType.UsdtPerpetual);

            //var usdcPerpetualSymbols = await _Client.FuturesApi.ExchangeData.GetSymbolsAsync(Bitget.Net.Enums.BitgetProductType.UsdcPerpetual);
            //var universalMarginPerpetualSymbols = await _Client.FuturesApi.ExchangeData.GetSymbolsAsync(Bitget.Net.Enums.BitgetProductType.UniversalMarginPerpetual);
            //var SimUsdtPerpetualSymbols = await _Client.FuturesApi.ExchangeData.GetSymbolsAsync(Bitget.Net.Enums.BitgetProductType.SimUsdtPerpetual);
            //var SimUsdcPerpetualSymbols = await _Client.FuturesApi.ExchangeData.GetSymbolsAsync(Bitget.Net.Enums.BitgetProductType.SimUsdcPerpetual);
            //var SimUniversalMarginPerpetualSymbols = await _Client.FuturesApi.ExchangeData.GetSymbolsAsync(Bitget.Net.Enums.BitgetProductType.SimUniversalMarginPerpetual);

            return usdtPerpetualSymbols.Data.Select(s => new Symbol() { Name = s.Id, Market = "USDT Perpetual", Description = s.Name }).ToList();
        }

        async Task<List<BarsCollection>> IDatafeedProvider.GetHistoricalDataAsync(List<Security> securities, int depth)
        {
            var reconSymbols = new List<string>();
            var historyCollection = new List<BarsCollection>();


            foreach (var period in Period.GetPeriods())
            {
                var symbols = securities.Where(w => w.Periods.Any(a => a == period)).Select(s => s.SymbolName).ToList();

                if (symbols.Count == 0)
                {
                    //load this period if exists symbols in reconSymbols
                    if (reconSymbols.Count > 0)
                    {
                        var reconHistory = await GetQuoteHistoryManyAsync(reconSymbols, period, 7);
                        historyCollection.AddRange(reconHistory);
                    }

                    continue;
                }

                var history = await GetQuoteHistoryManyAsync(symbols, period, depth);
                historyCollection.AddRange(history);


                //load this period if exists symbols in reconSymbols
                var reconSymbs = reconSymbols.Except(symbols).ToList();
                if (reconSymbs.Count > 0)
                {
                    var reconHistory = await GetQuoteHistoryManyAsync(reconSymbs, period, 7);
                    historyCollection.AddRange(reconHistory);
                }

                //add symbols to load history for reconstruct
                reconSymbols.AddRange(symbols.Except(reconSymbols));
            }

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

        private BitgetFuturesKlineInterval GetKlineIntervalByPeriod(string period)
        {
            switch(period)
            {
                case "MN1": return BitgetFuturesKlineInterval.OneMonth;
                case "W1": return BitgetFuturesKlineInterval.OneWeek;
                case "D1": return BitgetFuturesKlineInterval.OneDay;
                case "H4": return BitgetFuturesKlineInterval.FourHours;
                case "H1": return BitgetFuturesKlineInterval.OneHour;
                case "M30": return BitgetFuturesKlineInterval.ThirtyMinutes;
                case "M15": return BitgetFuturesKlineInterval.FifteenMinutes;
                case "M5": return BitgetFuturesKlineInterval.FiveMinutes;
                case "M1": return BitgetFuturesKlineInterval.OneMinute;
                default: return BitgetFuturesKlineInterval.OneMinute;
            }
        }

        private async Task<List<BarsCollection>> GetQuoteHistoryManyAsync(List<string> symbols, string period, int depth)
        {
            var result = new List<BarsCollection>();

            foreach(var symbol in symbols)
            {
                var barsCollection = await GetQuoteHistoryAsync(symbol, period, depth);
                result.Add(barsCollection);
            }

            return result;
        }

        private async Task<BarsCollection> GetQuoteHistoryAsync(string symbol, string period, int depth)
        {
            var response = await _Client.FuturesApi.ExchangeData.GetHistoricalKlinesAsync(symbol,
                                    GetKlineIntervalByPeriod(period),
                                    DateTime.Now.AddMinutes(-(depth * Period.PeriodToMinutes(period))),
                                    DateTime.Now.AddMinutes(5), BitgetKlineType.Market, depth
            );

            var result = new BarsCollection();
            result.SymbolName = symbol;
            result.Period = period;
            result.Bars = new List<ScreenerLib.Models.Bar>();

            // parse
            foreach (var item in response.Data)
            {

                var b = new ScreenerLib.Models.Bar();
                b.Time = item.Timestamp;
                b.Open = item.OpenPrice;
                b.High = item.HighPrice;
                b.Low = item.LowPrice;
                b.Close = item.ClosePrice;
                b.Volume = item.BaseVolume;
                result.Bars.Add(b);
            }

            return result;
        }

        private ScreenerLib.Models.Bar RecontructLastBar(DateTime timePrevBar, string period, List<BarsCollection> bars)
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

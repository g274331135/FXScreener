using Datafeed;
using Datafeed.Providers;
using Datafeed.Providers.BitgetNET;
using ScreenerLib.Interfaces;
using System;

namespace Datafeed
{
    public class DatafeedProviderFactory
    {
        public static IDatafeedProvider CreateProvider(string name)
        {
            switch (name.ToUpper())
            {
                case "MT4API": return new MT4APIProvider();
                case "BITGET.NET": return new BitgetProvider();
                default:
                    throw new ArgumentException("Unknown provider");
            }
        }
    }
}

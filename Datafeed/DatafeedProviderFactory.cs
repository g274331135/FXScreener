using Datafeed;
using Datafeed.Providers;
using ScreenerLib.Interfaces;
using System;

namespace Datafeed
{
    public class DatafeedProviderFactory
    {
        public static IDatafeedProvider CreateProvider(string name)
        {
            switch (name)
            {
                case "MT4API": return new MT4APIProvider();

                default:
                    throw new ArgumentException("Unknown provider");
            }
        }
    }
}

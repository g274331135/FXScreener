using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenerLib.Interfaces
{
    public interface IDatafeedProvider
    {
        string Name { get; }
        Task<bool> ConnectAsync(string jsonConfig);
        Task<List<Symbol>> GetAvailableSymbolsAsync();
        Task<List<BarsCollection>> GetHistoricalDataAsync(List<Security> securities, int depth);
    }
}

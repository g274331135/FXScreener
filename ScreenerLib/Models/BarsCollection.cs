using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ScreenerLib.Models
{

    public class BarsCollection
    {
        public string SymbolName { get; set; }

        public string Period { get; set; }

        public List<Bar> Bars { get; set; }

    }
}

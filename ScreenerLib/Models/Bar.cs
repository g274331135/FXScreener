using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace ScreenerLib.Models
{

    /// <summary>
    /// Quote history bar.
    /// </summary>
    [DataContract]
    public class Bar
    {
        public DateTime Time { get; set; }

        public decimal Open { get; set; }

        public decimal High { get; set; }

        public decimal Low { get; set; }

        public decimal Close { get; set; }

        public decimal Volume { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScreenerLib
{
    [DataContract]
    public class Security
    {
        [JsonIgnore]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "market")]
        public string Market { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string SymbolName { get; set; }

        [JsonProperty(PropertyName = "periods")]
        public string[] Periods 
        { 
            get {
                var periods = new List<string>();

                if (MN1 == true) periods.Add("MN1");
                if (W1 == true) periods.Add("W1");
                if (D1 == true) periods.Add("D1");
                if (H4 == true) periods.Add("H4");
                if (H1 == true) periods.Add("H1");
                if (M30 == true) periods.Add("M30");
                if (M15 == true) periods.Add("M15");
                if (M5 == true) periods.Add("M5");
                if (M1 == true) periods.Add("M1");

                return periods.ToArray();
            }

            set { 
                foreach (var period in value)
                {
                    if (period == "MN1") MN1 = true;
                    if (period == "W1") W1 = true;
                    if (period == "D1") D1 = true;
                    if (period == "H4") H4 = true;
                    if (period == "H1") H1 = true;
                    if (period == "M30") M30 = true;
                    if (period == "M15") M15 = true;
                    if (period == "M5") M5 = true;
                    if (period == "M1") M1 = true;
                }
            }
        }

        [JsonIgnore]
        public bool MN1 { get; set; }
        [JsonIgnore]
        public bool W1 { get; set; }
        [JsonIgnore]
        public bool D1 { get; set; }
        [JsonIgnore]
        public bool H4 { get; set; }
        [JsonIgnore]
        public bool H1 { get; set; }
        [JsonIgnore]
        public bool M30 { get; set; }
        [JsonIgnore]
        public bool M15 { get; set; }
        [JsonIgnore]
        public bool M5 { get; set; }
        [JsonIgnore]
        public bool M1 { get; set; }

        public override int GetHashCode()
        {
            return string.Format($"{this.Market}_{this.SymbolName}").GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Security))
                return false;

            var right = obj as Security;

            return this.GetHashCode() == right.GetHashCode();
        }
    }
}

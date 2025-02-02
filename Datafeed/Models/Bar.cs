using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace Datafeed.Models
{

    /// <summary>
    /// Quote history bar.
    /// </summary>
    [DataContract]
    public class Bar
    {
        /// <summary>
        /// Bar open time.
        /// </summary>
        /// <value>Bar open time.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Open price.
        /// </summary>
        /// <value>Open price.</value>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "open")]
        public decimal Open { get; set; }

        /// <summary>
        /// Maximum price.
        /// </summary>
        /// <value>Maximum price.</value>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "high")]
        public decimal High { get; set; }

        /// <summary>
        /// Minimum price.
        /// </summary>
        /// <value>Minimum price.</value>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "low")]
        public decimal Low { get; set; }

        /// <summary>
        /// Close price.
        /// </summary>
        /// <value>Close price.</value>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "close")]
        public decimal Close { get; set; }

        /// <summary>
        /// Volume.
        /// </summary>
        /// <value>Volume.</value>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "volume")]
        public decimal Volume { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bar {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}

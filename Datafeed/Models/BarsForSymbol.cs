using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Datafeed.Models
{

    /// <summary>
    /// QuoteHistoryMany reply
    /// </summary>
    [DataContract]
    public class BarsForSymbol
    {
        /// <summary>
        /// Symbols
        /// </summary>
        /// <value>Symbols</value>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "symbol")]
        public string SymbolName { get; set; }

        /// <summary>
        /// Bars
        /// </summary>
        /// <value>Bars</value>
        [DataMember(Name = "bars", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bars")]
        public List<Bar> Bars { get; set; }

        /// <summary>
        /// Error details
        /// </summary>
        /// <value>Error details</value>
        [DataMember(Name = "exception", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "exception")]
        public string Exception { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarsForSymbol {\n");
            sb.Append("  Symbol: ").Append(SymbolName).Append("\n");
            sb.Append("  Bars: ").Append(Bars).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
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

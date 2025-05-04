using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datafeed.Providers.BitgetNET.Models
{
    internal class BitgetNetConfig
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

        [JsonProperty(PropertyName = "passphrase")]
        public string Passphrase { get; set; }
    }
}

using Newtonsoft.Json;

namespace ScreenerLib.Models
{
    public class Account
    {
        public string Name { get; set; }

        public string Provider { get; set; }

        [JsonIgnore]
        public string Json { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

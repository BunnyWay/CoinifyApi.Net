using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model for the altrate object
    /// </summary>
    public class AltcoinRate
    {
        /// <summary>
        /// The name of the altcoin
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The rate of the altcoin
        /// </summary>
        [JsonProperty("rate")]
        public double Rate { get; set; }

        /// <summary>
        /// The altcoin code for this rate
        /// </summary>
        [JsonIgnore]
        public string AltcoinCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model for the rate object
    /// </summary>
    public class Rate
    {
        /// <summary>
        /// The name of the currency
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The sell rate of the currency
        /// </summary>
        [JsonProperty("sell")]
        public double SellRate { get; set; }

        /// <summary>
        /// The buy rate of the currency
        /// </summary>
        [JsonProperty("buy")]
        public double BuyRate { get; set; }

        /// <summary>
        /// The currency code for this rate
        /// </summary>
        [JsonIgnore]
        public string CurrencyCode { get; set; }
    }
}

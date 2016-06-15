using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model containing the original data used to create the invoice
    /// </summary>
    public class Native
    {
        /// <summary>
        /// The amount used to create the invoice and calculate the bitcoin amount.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// The currency used to create the invoice and calculate the bitcoin amount.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

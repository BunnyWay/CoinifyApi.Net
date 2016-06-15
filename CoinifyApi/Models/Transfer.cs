using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The data model used to hold the invoice transfer details after the invoice has been paid
    /// </summary>
    public class Transfer
    {
        /// <summary>
        /// The amount that will be transfered to you after the invoice has been paid
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// The currency of the transfer that will be transfered to you after the invoice has been paid
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

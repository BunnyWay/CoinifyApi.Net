using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model containing payment details
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// The time when the input request was made
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// The amount (in bitcoin) paid
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// The id of the blockchain transaction in which this payment was made
        /// </summary>
        [JsonProperty("txid")]
        public string Txid { get; set; }

        /// <summary>
        /// The number of confirmations on this payment
        /// </summary>
        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        /// <summary>
        /// Whether or not the invoice has expired when this payment was made
        /// </summary>
        [JsonProperty("expired")]
        public bool Expired { get; set; }
    }
}

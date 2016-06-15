using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model used for holding the payment details of the invoice
    /// </summary>
    public class Input
    {
        /// <summary>
        /// The input currency that the invoice has been requested to be paid in.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount of the above input currency to be paid by the customer.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// The address that the above amount should be paid to.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The address that the money should be returned to in case of an error.
        /// </summary>
        [JsonProperty("return_address")]
        public string ReturnAddress { get; set; }

        /// <summary>
        /// Wallet-compatible URI for this input currency request
        /// </summary>
        [JsonProperty("payment_uri")]
        public string PaymentUri { get; set; }

        /// <summary>
        /// Whether or not payment with this input currency has taken place and been verified.
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// 	The time when the input request was made
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}

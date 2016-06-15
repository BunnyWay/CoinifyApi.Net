using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model containing the bitcoin details
    /// </summary>
    public class Bitcoin
    {
        /// <summary>
        /// The total amount of the invoice
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// The bitcoin address to receive the payment for the invoice
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The amount that has already been paid for the invoice
        /// </summary>
        [JsonProperty("amount_paid")]
        public double AmountPaid { get; set; }

        /// <summary>
        /// The amount that needs to be paid for the invoice
        /// </summary>
        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }
    }
}

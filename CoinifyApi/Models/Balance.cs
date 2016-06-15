using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model holding the account balance data
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// The current balance of bitcoins in the account
        /// </summary>
        [JsonProperty("btc")]
        public double BitcoinBalance { get; set; }

        /// <summary>
        /// The current fiat balance in the account
        /// </summary>
        [JsonProperty("fiat")]
        public double FiatBalance { get; set; }

        /// <summary>
        /// The current fiat balance in the account
        /// </summary>
        [JsonProperty("fiat_currency")]
        public string FiatCurrency { get; set; }
    }
}

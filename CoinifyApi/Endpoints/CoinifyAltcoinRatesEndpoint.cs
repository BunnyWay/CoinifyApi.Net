using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The altcoin rates endpoint
    /// </summary>
    public class CoinifyAltcoinRatesEndpoint : CoinifyEndpoint
    {
        /// <summary>
        /// Create a new coinify altcoin rates endpoint
        /// </summary>
        /// <param name="coinify"></param>
        internal CoinifyAltcoinRatesEndpoint(Coinify coinify) : base(coinify, "altrates")
        {

        }

        /// <summary>
        ///  Load all the altcoin rates
        /// </summary>
        /// <returns></returns>
        public List<AltcoinRate> GetAltcoinRates()
        {
            var rates = new List<AltcoinRate>();
            var rateData = this.SendApiRequest<JObject>("");
            foreach (var rateObject in rateData.SelectTokens("*").ToList())
            {
                try
                {
                    dynamic parent = rateObject.Parent;
                    var rate = rateObject.ToObject<AltcoinRate>();
                    rate.AltcoinCode = parent.Name;
                    rates.Add(rate);
                }
                catch
                {
                    // Ignore the disclaimer
                }
            }
            return rates;
        }

        /// <summary>
        ///  Load the rate with the given altcoin code
        /// </summary>
        /// <returns></returns>
        public AltcoinRate GetRate(string rateCode)
        {
            var rate = this.SendApiRequest<AltcoinRate>($"/{rateCode}");
            rate.AltcoinCode = rateCode;
            return rate;
        }
    }
}

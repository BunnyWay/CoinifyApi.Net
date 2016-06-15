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
    /// The rates endpoint
    /// </summary>
    public class CoinifyRatesEndpoint : CoinifyEndpoint
    {
        /// <summary>
        /// Create a new coinify rates endpoint
        /// </summary>
        /// <param name="coinify"></param>
        internal CoinifyRatesEndpoint(Coinify coinify) : base(coinify, "rates")
        {

        }

        /// <summary>
        ///  Load all the rates
        /// </summary>
        /// <returns></returns>
        public List<Rate> GetAllRates()
        {
            var rates = new List<Rate>();
            var rateData = this.SendApiRequest<JObject>("");
            foreach (var rateObject in rateData.SelectTokens("*").ToList())
            {
                try
                {
                    dynamic parent = rateObject.Parent;

                    var rate = rateObject.ToObject<Rate>();
                    rate.CurrencyCode = parent.Name;
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
        ///  Load the rate with the given currency code
        /// </summary>
        /// <returns></returns>
        public Rate GetRate(string rateCode)
        {
            var rate = this.SendApiRequest<Rate>($"/{rateCode}");
            rate.CurrencyCode = rateCode;
            return rate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The base class for working with the Coinify API
    /// </summary>
    public class Coinify
    {
        /// <summary>
        /// The buffer used for reading the API response
        /// </summary>
        private byte[] _Buffer = new byte[4096];

        /// <summary>
        /// The base URL of the API
        /// </summary>
        private string _ApiUrl = "";

        /// <summary>
        /// The API key used for authenticatio
        /// </summary>
        private string _ApiKey = "";

        /// <summary>
        /// The API secret key used for authentication
        /// </summary>
        private string _ApiSecret = "";


        /// <summary>
        /// The rates endpoint
        /// </summary>
        public CoinifyRatesEndpoint Rates { get; private set; }
        /// <summary>
        /// The rates endpoint
        /// </summary>
        public CoinifyAltcoinRatesEndpoint AltcoinRates { get; private set; }
        /// <summary>
        /// The balance endpoint
        /// </summary>
        public CoinifyBalanceEndpoint Balance { get; private set; }
        /// <summary>
        /// The invoice endpoint
        /// </summary>
        public CoinifyInvoiceEndpoint Invoice { get; private set; }

        /// <summary>
        /// Create a new coinify object
        /// </summary>
        public Coinify(string apiKey, string apiSecret, string apiUrl)
        {
            this._ApiKey = apiKey;
            this._ApiSecret = apiSecret;
            this._ApiUrl = apiUrl;

            this.Rates = new CoinifyRatesEndpoint(this);
            this.AltcoinRates = new CoinifyAltcoinRatesEndpoint(this);
            this.Balance = new CoinifyBalanceEndpoint(this);
            this.Invoice = new CoinifyInvoiceEndpoint(this);
        }

        /// <summary>
        /// Create an API request to the Coinify API
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal T SendApiRequest<T>(CoinifyEndpoint endpoint, string path, string postData = null) where T : new()
        {
            // Authenticate
            var nonce = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            var message = nonce + this._ApiKey;
            var signature = Crypto.HmacSHA256(message, this._ApiSecret).ToLower();
            var authHeader = $"Coinify apikey=\"{this._ApiKey}\", nonce=\"{nonce}\", signature=\"{signature}\"";

            // Create the web request
            var request = (HttpWebRequest)HttpWebRequest.Create(_ApiUrl + endpoint.EndpointName + path);
            request.Headers["Authorization"] = authHeader;
            if(postData != null)
            {
                request.Method = "POST";
                using (var requestStream = request.GetRequestStream())
                {
                    var postDataByes = Encoding.UTF8.GetBytes(postData);
                    requestStream.Write(postDataByes, 0, postDataByes.Length);
                    requestStream.Flush();
                }
            }

            // Get the response
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {

                    // Read the response
                    int bytesRead = 0;
                    var responseBodyBuilder = new StringBuilder();
                    while ((bytesRead = stream.Read(this._Buffer, 0, this._Buffer.Length)) > 0)
                    {
                        responseBodyBuilder.Append(Encoding.UTF8.GetString(this._Buffer, 0, bytesRead));
                    }

                    var result = JsonConvert.DeserializeObject<CoinifyApiResponse<T>>(responseBodyBuilder.ToString());
                    if (!result.Success)
                    {
                        // TODO: include data
                        throw new CoinifyApiException();
                    }

                    return result.Data;
                }
            }
        }
    }
}

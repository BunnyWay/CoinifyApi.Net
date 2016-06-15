using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinifyApi
{
    /// <summary>
    /// A coinify endpoint 
    /// </summary>
    public class CoinifyEndpoint
    {
        /// <summary>
        /// The coinify client used for API communication
        /// </summary>
        public Coinify CoinifyClient { get; private set; }

        /// <summary>
        /// Gets the endpoint name
        /// </summary>
        public string EndpointName { get; private set; }

        /// <summary>
        /// Create a new coinify endpoint
        /// </summary>
        internal CoinifyEndpoint(Coinify coinify, string endpointName)
        {
            this.CoinifyClient = coinify;
            this.EndpointName = endpointName;
        }

        /// <summary>
        /// Create an API request to the Coinify API
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        protected T SendApiRequest<T>(string path = "", string postData = null) where T : new()
        {
            return this.CoinifyClient.SendApiRequest<T>(this, path, postData);
        }
    }
}

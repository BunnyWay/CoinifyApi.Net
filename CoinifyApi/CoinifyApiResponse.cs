using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The base class for deserializing the coinify API response
    /// </summary>
    public class CoinifyApiResponse<T> where T : new()
    {
        /// <summary>
        /// True if the API request was successful
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// The data returned in the response
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}

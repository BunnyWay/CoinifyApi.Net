using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The base class for deserializing the coinify API response
    /// </summary>
    public class CoinifyApiResponse<T> where T : new()
    {
        public class CoinifyErrorResponse
        {
            /// <summary>
            /// Error code
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }

            /// <summary>
            /// Error message
            /// </summary>
            [JsonProperty("message")]
            public string Message { get; set; }

            /// <summary>
            /// Error URL
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
        }

        /// <summary>
        /// True if the API request was successful (Data will be present) or not (Error will be present)
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// The data returned in the response
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("error")]
        public CoinifyErrorResponse Error { get; set; }
    }
}

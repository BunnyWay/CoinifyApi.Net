using System;

namespace CoinifyApi
{
    /// <summary>
    /// An exception thrown when an API request fails
    /// </summary>
    public class CoinifyApiException : Exception
    {
        public CoinifyApiException(string code, string message) : base($"{code}: {message}")
        {
        }
    }
}

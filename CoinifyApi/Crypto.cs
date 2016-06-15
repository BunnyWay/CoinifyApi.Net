using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CoinifyApi
{
    /// <summary>
    /// A collection of helper methods for working with cryptography
    /// </summary>
    public class Crypto
    {
        /// <summary>
        /// Create a SHA256 hash of the given string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String SHA256(string value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Join("", hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        }

        /// <summary>
        /// Create a HmacSHA256 hash of the given string
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string HmacSHA256(string data, string key)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.ASCII.GetBytes(key)))
            {
                return string.Join("", 
                    hmac
                        .ComputeHash(Encoding.ASCII.GetBytes(data))
                        .Select(item => item.ToString("x2")));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinifyApi
{
    /// <summary>
    /// The endpoint for loading the user's account balance
    /// </summary>
    public class CoinifyBalanceEndpoint : CoinifyEndpoint
    {
        /// <summary>
        /// Create a new coinify balance endpoint
        /// </summary>
        /// <param name="coinify"></param>
        internal CoinifyBalanceEndpoint(Coinify coinify) : base(coinify, "balance")
        {

        }

        /// <summary>
        ///  Load the current account balanace
        /// </summary>
        /// <returns></returns>
        public Balance GetBalance()
        {
            var rate = this.SendApiRequest<Balance>();
            return rate;
        }
    }
}

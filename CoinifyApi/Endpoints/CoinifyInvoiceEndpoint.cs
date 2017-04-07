using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The endpoint for working with invoices
    /// </summary>
    public class CoinifyInvoiceEndpoint : CoinifyEndpoint
    {
        /// <summary>
        /// Create a new coinify invoice endpoint
        /// </summary>
        /// <param name="coinify"></param>
        internal CoinifyInvoiceEndpoint(Coinify coinify) : base(coinify, "invoices")
        {

        }

        /// <summary>
        /// Get the list of all invoices
        /// </summary>
        /// <param name="limit">Maximum number of invoices to retrieve. Maximum is 200.</param>
        /// <param name="offset">How many invoices to skip.</param>
        /// <param name="includeExpired">If set to true, expired invoices are included in the result. Default is not to include expired invoices.</param>
        /// <returns></returns>
        public List<Invoice> GetAllInvoices(int limit = 100, int offset = 0, bool includeExpired = false)
        {
            return this.SendApiRequest<List<Invoice>>($"?limit={limit}&offset={offset}&include_expired={includeExpired}");
        }

        /// <summary>
        /// Get the invoice with the given id
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public Invoice GetInvoice(int invoiceId)
        {
            return this.SendApiRequest<Invoice>($"/{invoiceId}");
        }

        /// <summary>
        /// Create a new invoice
        /// </summary>
        public Invoice CreateInvoice(double amount, string currency, string description = null, string custom = null, string callbackUrl = null, string callbackEmail = null, string returnUrl = null, string cancelUrl = null, string inputCurrency = null, string inputReturnAddress = null)
        {
            var invoice = new InvoiceCreate()
            {
                Amount = amount,
                Currency = currency,
                Description = description,
                Custom = custom,
                CallbackEmail = callbackEmail,
                CallbackUrl = callbackUrl,
                CancelUrl  = cancelUrl,
                InputCurrency = inputCurrency,
                InputReturnAddress = inputReturnAddress,
                ReturnUrl = returnUrl
            };
            var response = this.SendApiRequest<Invoice>("", 
                JsonConvert.SerializeObject(
                    invoice, 
                    Formatting.None, 
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    })
                );

            return response;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model used for creating invoices
    /// </summary>
    internal class InvoiceCreate
    {
        /// <summary>
        /// Create a new invoice create object
        /// </summary>
        public InvoiceCreate()
        {
            this.PluginName = "Coinify .NET";
            this.PluginVersion = "1.0";
        }

        /// <summary>
        /// The amount of the invoice
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// The currency of the invoice
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The name of the plugin used to call this API
        /// </summary>
        [JsonProperty("plugin_name")]
        public string PluginName { get; set; }

        /// <summary>
        /// The version of the above plugin
        /// </summary>
        [JsonProperty("plugin_version")]
        public string PluginVersion { get; set; }

        /// <summary>
        /// The description of the invoice
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A custom object that will be added into the 
        /// </summary>
        [JsonProperty("custom")]
        public object Custom { get; set; }

        /// <summary>
        /// The URL that Coinify calls when the invoice state changes.
        /// </summary>
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The email address to send a mail to when the invoice state changes
        /// </summary>
        [JsonProperty("callback_email")]
        public string CallbackEmail { get; set; }

        /// <summary>
        /// The URL where Coinify redirects the customer when the invoice has been paid
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL where Coinify redirects the customer if they cancel the URL
        /// </summary>
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        /// <summary>
        /// Input currency that the invoice should be paid in. See supported input currencies for retrieving a list of supported currencies.
        /// </summary>
        [JsonProperty("input_currency")]
        public string InputCurrency { get; set; } = "BTC";

        /// <summary>
        /// The address that the money should be returned to in case of an error. Mandatory if input_currency is not "BTC" - otherwise unused.
        /// </summary>
        [JsonProperty("input_return_address")]
        public string InputReturnAddress { get; set; }
    }
}

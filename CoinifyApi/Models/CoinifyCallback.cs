using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The model holding the coinify callback data
    /// </summary>
    public class CoinifyCallback
    {
        /// <summary>
        /// The event name indicating that the state variable of an invoice object has changed
        /// </summary>
        public const string EventTypeInvoiceStateChange = "invoice_state_change";
        /// <summary>
        /// The event name indicating that there was a manual resend of invoice callback from dashboard
        /// </summary>
        public const string EventTypeInvoiceManualResend = "invoice_manual_resend";
        /// <summary>
        /// The event name indicating that the state variable of a buy order object has changed
        /// </summary>
        public const string EventTypeBuyOrderStateChange = "buy_order_state_change";


        /// <summary>
        /// The reason for the callback. The event dictates the data type of the data parameter.
        /// </summary>
        [JsonProperty("event")]
        public string EventType { get; set; }

        /// <summary>
        /// The time that this callback was initiated
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// The object, dependent on the event parameter
        /// </summary>
        [JsonProperty("data")]
        public Invoice InvoiceData { get; set; }
    }
}

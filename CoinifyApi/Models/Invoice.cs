using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinifyApi
{
    /// <summary>
    /// The JSON model for the invoice object
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// The invoice is awaiting payment
        /// </summary>
        public const string StateNew = "new";

        /// <summary>
        /// The invoice has been paid, but the payments are not yet verified
        /// </summary>
        public const string StatePaid = "paid";

        /// <summary>
        /// The invoice has been paid, and payments are verified
        /// </summary>
        public const string StateComplete = "complete";

        /// <summary>
        /// The invoice has expired
        /// </summary>
        public const string StateExpired = "expired";

        /// <summary>
        /// Normal payment
        /// </summary>
        public const string TypeNormal = "normal";

        /// <summary>
        /// The original payment received too much payment or received a payment too late
        /// </summary>
        public const string TypeExtra = "extra";

        /// <summary>
        /// The payment received too little payment within the time limit and the payment amounts were adjusted to match the actual paid amount
        /// </summary>
        public const string TypeUnderpaid = "underpaid";

        /// <summary>
        /// The ID of the invoice
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The currency of the invoice
        /// </summary>
        [JsonProperty("currency")]
        public long Currency { get; set; }

        /// <summary>
        /// The date and time when the invoice was created
        /// </summary>
        [JsonProperty("create_time")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// The state of the invoice
        /// </summary>
        /// <remarks>
        /// Can be new, paid, complete or expired
        /// </remarks>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The payment type
        /// </summary>
        /// <remarks>
        /// Can be normal, underpaid or extra
        /// </remarks>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The bitcoin details for this specific payment
        /// </summary>
        [JsonProperty("bitcoin")]
        public Bitcoin Bitcoin { get; set; }

        /// <summary>
        /// The amount used to create the invoice and calculate the bitcoin amount.
        /// </summary>
        [JsonProperty("native")]
        public Native Native { get; set; }

        /// <summary>
        /// The amount that we will transfer to you once the invoice has been paid. 
        /// </summary>
        [JsonProperty("transfer")]
        public Transfer Transfer { get; set; }

        /// <summary>
        /// The description of the invoice
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// A custom object sent with the invoice
        /// </summary>
        [JsonProperty("custom")]
        public object Custom { get; set; }

        /// <summary>
        /// The URL where the payment can be paid
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// List of requests to pay with other input currencies. See section on
        /// </summary>
        [JsonProperty("inputs")]
        public List<Input> Inputs { get; set; }

        // <summary>
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
        /// The recorded payments for this invoice
        /// </summary>
        [JsonProperty("payments")]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// The ID of the original invoice for the certain sub-invoice
        /// </summary>
        [JsonProperty("original_invoice_id")]
        public int OriginalInvoiceId { get; set; }

        /// <summary>
        /// The IDs of the sub-invoices for the certain original invoice
        /// </summary>
        [JsonProperty("sub_invoice_ids")]
        public int[] SubInvoiceId { get; set; }
    }
}

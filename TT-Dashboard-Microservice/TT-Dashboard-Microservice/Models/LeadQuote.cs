using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class LeadQuote
    {
        public LeadQuote()
        {
            LeadQuoteRevisions = new HashSet<LeadQuoteRevision>();
        }

        public int LeadQuoteId { get; set; }
        public int LeadId { get; set; }
        public DateTime? QuoteDate { get; set; }
        public string ShippingLocation { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
        public byte[] Logo { get; set; }
        public string BillingContactName { get; set; }
        public string BillingLocation { get; set; }
        public string ShippingContact { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string BillingEmail { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string ShippingLocationName { get; set; }

        public virtual Lead Lead { get; set; }
        public virtual ICollection<LeadQuoteRevision> LeadQuoteRevisions { get; set; }
    }
}

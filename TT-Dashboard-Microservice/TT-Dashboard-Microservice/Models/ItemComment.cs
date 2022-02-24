using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ItemComment
    {
        public int ItemCommentId { get; set; }
        public int EmployeeId { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public int? CustomerId { get; set; }
        public int? ProjectId { get; set; }
        public int? LeadId { get; set; }
        public int? TroubleTicketId { get; set; }
        public int Type { get; set; }
        public int? LeadQuoteRevisionId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Lead Lead { get; set; }
        public virtual LeadQuoteRevision LeadQuoteRevision { get; set; }
        public virtual Project Project { get; set; }
        public virtual TroubleTicket TroubleTicket { get; set; }
    }
}

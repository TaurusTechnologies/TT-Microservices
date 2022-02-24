using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ItemFollowUp
    {
        public int ItemFollowUpId { get; set; }
        public int? LeadId { get; set; }
        public int? CustomerId { get; set; }
        public int? TroubleTicketId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime FollowUpWhen { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
        public int? AssignedToEmployeeId { get; set; }
        public int? PtorequestId { get; set; }
        public int? LeadQuoteRevisionId { get; set; }

        public virtual Employee AssignedToEmployee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Lead Lead { get; set; }
        public virtual LeadQuoteRevision LeadQuoteRevision { get; set; }
        public virtual Project Project { get; set; }
        public virtual Ptorequest Ptorequest { get; set; }
        public virtual TroubleTicket TroubleTicket { get; set; }
    }
}

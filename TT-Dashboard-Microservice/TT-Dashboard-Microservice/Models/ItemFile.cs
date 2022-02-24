using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ItemFile
    {
        public int ItemFileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public bool IsImage { get; set; }
        public string Path { get; set; }
        public string ThumbnailPath { get; set; }
        public int Size { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Timestamp { get; set; }
        public int? CustomerId { get; set; }
        public int? ProjectId { get; set; }
        public int? LeadId { get; set; }
        public int? TroubleTicketId { get; set; }
        public bool? IsPrivate { get; set; }
        public int? RoomId { get; set; }
        public int? EmployeeDocumentId { get; set; }
        public int? LeadQuoteRevisionId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee EmployeeDocument { get; set; }
        public virtual Lead Lead { get; set; }
        public virtual LeadQuoteRevision LeadQuoteRevision { get; set; }
        public virtual Project Project { get; set; }
        public virtual Room Room { get; set; }
        public virtual TroubleTicket TroubleTicket { get; set; }
    }
}

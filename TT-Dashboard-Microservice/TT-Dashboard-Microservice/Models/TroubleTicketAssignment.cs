using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class TroubleTicketAssignment
    {
        public int TroubleTicketAssignment1 { get; set; }
        public int TroubleTicketId { get; set; }
        public int EmployeeId { get; set; }
        public bool? IsPrimary { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual TroubleTicket TroubleTicket { get; set; }
    }
}

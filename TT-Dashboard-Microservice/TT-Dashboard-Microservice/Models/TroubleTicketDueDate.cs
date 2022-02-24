using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class TroubleTicketDueDate
    {
        public int TroubleTicketDueDateId { get; set; }
        public int TroubleTicketId { get; set; }
        public DateTime? DueDate { get; set; }
        public string Description { get; set; }

        public virtual TroubleTicket TroubleTicket { get; set; }
    }
}

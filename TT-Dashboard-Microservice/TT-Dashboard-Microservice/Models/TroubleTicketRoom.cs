using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class TroubleTicketRoom
    {
        public int TroubleTicketRoomId { get; set; }
        public int TroubleTicketId { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
        public virtual TroubleTicket TroubleTicket { get; set; }
    }
}

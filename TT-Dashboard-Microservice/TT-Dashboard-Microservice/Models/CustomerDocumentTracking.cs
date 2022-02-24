using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class CustomerDocumentTracking
    {
        public int CustomerDocumentTrackingId { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public DateTime DocumentExpirationDate { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectProductReceived
    {
        public int ProjectProductReceivedId { get; set; }
        public int ProjectProductId { get; set; }
        public int QuantityReceived { get; set; }
        public DateTime DateReceived { get; set; }
        public int ReceivedByEmployeeId { get; set; }

        public virtual ProjectProduct ProjectProduct { get; set; }
        public virtual Employee ReceivedByEmployee { get; set; }
    }
}

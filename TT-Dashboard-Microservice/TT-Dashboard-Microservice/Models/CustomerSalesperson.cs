using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class CustomerSalesperson
    {
        public int CustomerSalespersonId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class EmployeeExpirationItem
    {
        public int EmployeeExpirationItemId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateExpires { get; set; }
        public string Description { get; set; }
        public bool? IsSafety { get; set; }

        public virtual Employee Employee { get; set; }
    }
}

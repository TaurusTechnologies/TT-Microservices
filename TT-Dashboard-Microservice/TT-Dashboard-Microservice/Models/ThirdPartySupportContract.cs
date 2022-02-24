using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ThirdPartySupportContract
    {
        public int ThirdPartySupportContractId { get; set; }
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public virtual Project Project { get; set; }
    }
}

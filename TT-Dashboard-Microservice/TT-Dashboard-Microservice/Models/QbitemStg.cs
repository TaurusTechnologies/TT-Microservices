using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class QbitemStg
    {
        public string ListId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string Type { get; set; }
    }
}

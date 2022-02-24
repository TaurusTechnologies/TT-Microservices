using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Ptostatus
    {
        public Ptostatus()
        {
            Ptorequests = new HashSet<Ptorequest>();
        }

        public int PtostatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ptorequest> Ptorequests { get; set; }
    }
}

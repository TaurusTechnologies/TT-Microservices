using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class PtorequestDay
    {
        public int PtorequestDayId { get; set; }
        public int PtorequestId { get; set; }
        public DateTime ForDay { get; set; }
        public int Hours { get; set; }

        public virtual Ptorequest Ptorequest { get; set; }
    }
}

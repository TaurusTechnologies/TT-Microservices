using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class QbemployeeStg
    {
        public string ListId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string Email { get; set; }
        public decimal? SickHoursAvailable { get; set; }
        public decimal? VacationHoursAvailable { get; set; }
        public DateTime? HiredDate { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}

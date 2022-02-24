using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Location
    {
        public Location()
        {
            Employees = new HashSet<Employee>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public string OfficePhone { get; set; }
        public string OfficeFax { get; set; }
        public bool PersonnelAtLocation { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

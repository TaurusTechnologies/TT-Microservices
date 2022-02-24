using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectProduct
    {
        public ProjectProduct()
        {
            ProjectProductReceiveds = new HashSet<ProjectProductReceived>();
        }

        public int ProjectProductId { get; set; }
        public int ProjectId { get; set; }
        public int Quantity { get; set; }
        public int? ProductId { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public int? OrderedByEmployeeId { get; set; }
        public DateTime? OrderedOn { get; set; }
        public int? ReceivedByEmployeeId { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public string BinNumber { get; set; }
        public string OrderNotes { get; set; }
        public int ProjectRoomId { get; set; }
        public int? DisplayOrder { get; set; }
        public string Vendor { get; set; }
        public decimal? QuotePrice { get; set; }
        public string Ponumber { get; set; }
        public int Status { get; set; }
        public string ModifyReason { get; set; }
        public bool? SuppliedByOther { get; set; }
        public string SerialNumbers { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime? Eta { get; set; }

        public virtual Employee OrderedByEmployee { get; set; }
        public virtual Product Product { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectRoom ProjectRoom { get; set; }
        public virtual Employee ReceivedByEmployee { get; set; }
        public virtual ICollection<ProjectProductReceived> ProjectProductReceiveds { get; set; }
    }
}

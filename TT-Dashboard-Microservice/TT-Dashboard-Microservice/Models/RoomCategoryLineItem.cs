using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class RoomCategoryLineItem
    {
        public RoomCategoryLineItem()
        {
            RoomServicePlans = new HashSet<RoomServicePlan>();
        }

        public int RoomCategoryLineItemId { get; set; }
        public int RevisionRoomProductCategoryId { get; set; }
        public bool IsSuppliedByOther { get; set; }
        public int Quantity { get; set; }
        public int? ProductId { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public decimal Msrp { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal LineTotal { get; set; }
        public decimal Cost { get; set; }
        public decimal CostTotal { get; set; }
        public int MarkupPercent { get; set; }
        public string Notes { get; set; }
        public int LineItemOrder { get; set; }
        public decimal? Labor { get; set; }
        public decimal? Expense { get; set; }
        public decimal? OrigMsrp { get; set; }
        public bool CostOverride { get; set; }

        public virtual Product Product { get; set; }
        public virtual RevisionRoomProductCategory RevisionRoomProductCategory { get; set; }
        public virtual ICollection<RoomServicePlan> RoomServicePlans { get; set; }
    }
}

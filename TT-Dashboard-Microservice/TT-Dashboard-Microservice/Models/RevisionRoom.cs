using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class RevisionRoom
    {
        public RevisionRoom()
        {
            RevisionRoomProductCategories = new HashSet<RevisionRoomProductCategory>();
        }

        public int RevisionRoomId { get; set; }
        public int LeadQuoteRevisionId { get; set; }
        public int? RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }
        public int RoomOrder { get; set; }
        public bool Purchased { get; set; }
        public bool? OverrideTotals { get; set; }
        public decimal? ServicesTotalOverride { get; set; }
        public decimal? DesignTotalOverride { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? Taxes { get; set; }
        public string ShippingMethod { get; set; }
        public decimal? RoomTotals { get; set; }
        public string Location { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Sowsummary { get; set; }
        public string SowkeyComponents { get; set; }
        public string SowclientRequirements { get; set; }

        public virtual LeadQuoteRevision LeadQuoteRevision { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<RevisionRoomProductCategory> RevisionRoomProductCategories { get; set; }
    }
}

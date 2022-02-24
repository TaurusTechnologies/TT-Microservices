using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class RoomServicePlan
    {
        public int RoomServicePlanId { get; set; }
        public int RoomId { get; set; }
        public int ProjectId { get; set; }
        public int RoomCategoryLineItemId { get; set; }
        public DateTime DateServicePlanStart { get; set; }
        public DateTime DateServicePlanEnd { get; set; }

        public virtual Project Project { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomCategoryLineItem RoomCategoryLineItem { get; set; }
    }
}

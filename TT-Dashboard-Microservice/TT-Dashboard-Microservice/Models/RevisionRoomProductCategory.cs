using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class RevisionRoomProductCategory
    {
        public RevisionRoomProductCategory()
        {
            RoomCategoryLineItems = new HashSet<RoomCategoryLineItem>();
        }

        public int RevisionRoomProductCategoryId { get; set; }
        public int RevisionRoomId { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductCategoryOrder { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual RevisionRoom RevisionRoom { get; set; }
        public virtual ICollection<RoomCategoryLineItem> RoomCategoryLineItems { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
            RevisionRoomProductCategories = new HashSet<RevisionRoomProductCategory>();
        }

        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public int? QuoteDisplayOrder { get; set; }
        public int? DefaultMarginPercent { get; set; }
        public int? ManagerMarkupAlertThreshold { get; set; }
        public bool? InServicesQuote { get; set; }
        public bool? InDesignQuote { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RevisionRoomProductCategory> RevisionRoomProductCategories { get; set; }
    }
}

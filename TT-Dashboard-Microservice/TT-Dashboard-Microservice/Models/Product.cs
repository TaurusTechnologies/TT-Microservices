using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Product
    {
        public Product()
        {
            InverseSupercededBy = new HashSet<Product>();
            PriceCalculations = new HashSet<PriceCalculation>();
            ProjectMclproducts = new HashSet<ProjectMclproduct>();
            ProjectProducts = new HashSet<ProjectProduct>();
            RoomCategoryLineItems = new HashSet<RoomCategoryLineItem>();
            ServicePlans = new HashSet<ServicePlan>();
        }

        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public decimal Msrp { get; set; }
        public decimal Price { get; set; }
        public DateTime? Eoldate { get; set; }
        public bool Superceded { get; set; }
        public int? Multiplier { get; set; }
        public int? SupercededById { get; set; }
        public bool? IsDefaultOnQuote { get; set; }
        public bool? IsCalculatedCost { get; set; }
        public int? DefaultQuantity { get; set; }
        public int? DefaultOrder { get; set; }
        public int? DefaultMargin { get; set; }
        public bool? IsInstallation { get; set; }
        public bool? IsProgramming { get; set; }
        public bool? IsDefaultOnMcl { get; set; }
        public int? DefaultMclquantity { get; set; }
        public int? DefaultMclorder { get; set; }
        public string QbvendorId { get; set; }
        public string Vendor { get; set; }
        public bool IsServicePlan { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Product SupercededBy { get; set; }
        public virtual ICollection<Product> InverseSupercededBy { get; set; }
        public virtual ICollection<PriceCalculation> PriceCalculations { get; set; }
        public virtual ICollection<ProjectMclproduct> ProjectMclproducts { get; set; }
        public virtual ICollection<ProjectProduct> ProjectProducts { get; set; }
        public virtual ICollection<RoomCategoryLineItem> RoomCategoryLineItems { get; set; }
        public virtual ICollection<ServicePlan> ServicePlans { get; set; }
    }
}

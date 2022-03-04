using System;
using System.Collections.Generic;
using System.Linq;

namespace TT_Dashboard_Microservice.Models.Views
{
    public class ProjectPartDto
    {
        public ProjectRoom ProjectRoom { get; set; }
        public int Quantity { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public decimal? QuotePrice { get; set; }
        public decimal? Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string BinNumber { get; set; }
    }

    public class ProjectRoomDto
    {
        public int ProjectRoomId { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
    }

    //public static ProductDto AsDto(this ProjectMCLProduct item, IQueryable<Product> products = null)
    //{
    //    Product product = null;
    //    if (item.Vendor != null && products != null)
    //    {
    //        product = products.FirstOrDefault(p => p.ProductId == item.ProductId);

    //    }

    //    return new ProductDto
    //    {
    //        Project = item.Project,
    //        RoomName = item.ProjectRoom.Room.RoomName,
    //        ProjectRoom = item.ProjectRoom,
    //        ProjectRoomId = item.ProjectRoom.ProjectRoomId,
    //        Description = item.Description,
    //        PoNumber = item.PONumber,
    //        PartNumber = item.PartNumber,
    //        Manufacturer = item.Manufacturer,
    //        Vendor = product != null ? product.Vendor : "",
    //        QuotePrice = item.QuotePrice,
    //        Cost = item.Price,
    //        Quantity = item.Quantity,
    //        ProductId = item.ProjectMCLProductId,
    //        OrderDate = item.OrderedOn,
    //        OrderedBy = item.Employee,
    //        ReceivedDate = item.ReceivedOn,
    //        IsMcl = true,
    //        Price = item.Price,
    //        BinNumber = item.BinNumber,
    //        SuppliedByOther = false,
    //        Status = item.Status
    //    };

    //}

    public class ProjectVD
    {
        public Project Project;
        public IEnumerable<ProjectPartDto> ProjectParts;
        public LeadQuoteRevision LeadQuoteRevision;
        public ServicePlan ServicePlan;
        public ThirdPartySupportContract ThirdPartySupportContract;
        //public IEnumerable<QBInvoice> ProjectInvoices;
        public IEnumerable<Expense> Expenses;
        public LeadQuote LeadQuote;
        public decimal LaborActual;
        public decimal ProgrammingActual;
        public decimal ProductActual;
        public DateTime? Start;
        public DateTime? Completion;
        public string DateDescription;
        public DateTime? Completed;

        public DateTime? TimeNow;
        public IEnumerable<Location> Locations;
        public IList<ProjectStartStopDate> StartStopDates;
        //public IEnumerable<ServicePlan> ServicePlans
        //{
        //    get { return DataContext.ServicePlans; }
        //}
        //public IEnumerable<QBInvoiceLineItem> ProjectInvoiceLineItems;
        public int ProjectId;
        public decimal AmountInvoiced;
        public decimal AmountOutstanding;
        public bool InProcurementTeam;
        public IEnumerable<ProjectRoomDto> ProjectRooms;
        //public IEnumerable<ProductDto> LineItems;
        //public IEnumerable<ProductDto> LineItemsToOrder;
        //public IEnumerable<ProductDto> LineItemsToReceive;
        //public SessionUserViewModel CurrentUser { get; set; }

        public int ProjectRoomImageCount(int id)
        {
            //var projectRoom = DataContext.ProjectRooms.Single(x => x.ProjectRoomId == id);
            //var images = DataContext.ItemFiles.Where(x =>
            //    x.ProjectId == projectRoom.ProjectId && x.RoomId == projectRoom.RoomId && x.IsImage);
            //return images.Count();
        }

    }
}
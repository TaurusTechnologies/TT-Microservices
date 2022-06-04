using System;
using System.Collections.Generic;
using System.Linq;
using TT_Dashboard_Microservice.Models.Dtos;

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

    public class ProductDto
    {

    }

    public class ProductReceivedDto
    {

    }

    public class EmployeeDto
    {

    }

    public class ProjectProductFieldUpdateDto
    {
        public string field { get; set; }
        public string value { get; set; }

    }

    public class ProjectProductDto
    {
        public bool received { get; set; }
        public int projectProductId { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public int quantity { get; set; }
        public string binNumber { get; set; }
        public string vendor { get; set; }
        public string trackingNumber { get; set; }
        public decimal? quotePrice { get; set; }
        public decimal? price { get; set; }
        public string manufacturer { get; set; }
        public string partNumber { get; set; }
        public DateTime? eta { get; set; }
        public string poNumber { get; set; }
        public string orderNotes { get; set; }

    }

    public class ProjectRoomDto
    {
        public int projectRoomId { get; set; }
        public int roomId { get; set; }
        public string roomName { get; set; }
        public bool isActive { get; set; }

        public List<ProjectProductDto> products { get; set; }
    }

    public class ProjectRoomsDto
    {

    }

    public class ProjectCustomerDto
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
    }

    public class ProjectLocationDto
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }

    public class ProjectDto
    {
        public int projectId { get; set; }
        public string name { get; set; }
        public DateTime? start { get; set; }
        public DateTime? completion { get; set; }
        public string dateDescription { get; set; }
        public IList<ProjectStartStopDateDto> startStopDates { get; set; }
        public string jobNumber { get; set; }
        public string poNumber { get; set; }

        public ProjectCustomerDto customer;
        public string phoneNumber { get; set; }
        public string cellNumber { get; set; }
        public string contactName { get; set; }
        public string contactEmail { get; set; }

        public ProjectLocationDto installAddress { get; set; }
        public ProjectLocationDto shippingAddress { get; set; }
    }

    // OLD class
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
            return 0; // TODO - re-integrate.

            //var projectRoom = DataContext.ProjectRooms.Single(x => x.ProjectRoomId == id);
            //var images = DataContext.ItemFiles.Where(x =>
            //    x.ProjectId == projectRoom.ProjectId && x.RoomId == projectRoom.RoomId && x.IsImage);
            //return images.Count();
        }

    }
}
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
        public int employeeId { get; set; }
        public string fullName { get; set; }
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

    public class ProjectCustomerDto
    {
        public int customerId { get; set; }
        public string name { get; set; }
    }

    public class ProjectLocationDto
    {
        public string locationName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }

    public class ProjectMetricsDto
    {
        public decimal amountInvoiced { get; set; }
        public decimal amountOutstanding { get; set; }
        public decimal laborActual { get; set; }
    }

    public class ItemHistoryDto
    {
        public int Type { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public int AuthorId { get; set; }
        public string Timestamp { get; set; }
        public int id { get; set; }
    }

    public class ProjectDto
    {
        public int projectId { get; set; }
        public string name { get; set; }

        public ProjectCustomerDto customer { get; set; }
        public DateTime? start { get; set; }
        public DateTime? completion { get; set; }
        public string dateDescription { get; set; }
        public IList<ProjectStartStopDateDto> startStopDates { get; set; }
        public string jobNumber { get; set; }
        public string poNumber { get; set; }

        public string phoneNumber { get; set; }
        public string faxNumber { get; set; }
        public string cellNumber { get; set; }
        public string contactName { get; set; }
        public string contactEmail { get; set; }

        public ProjectLocationDto installAddress { get; set; }
        public ProjectLocationDto shippingAddress { get; set; }
        public string billingName { get; set; }
        public string billingEmail { get; set; }

        public ProjectLocationDto billingAddress { get; set; }
        public string notes { get; set; }

        public bool isLegacyServicePlan { get; set; }
        public ProjectMetricsDto metrics { get; set; }      // Values that need to be computed.
        public decimal? codingBudget { get; set; }
        public decimal? codingActual { get; set; }
        public decimal? expenseBudget { get; set; }
        public decimal? laborBudget { get; set; }
        public decimal? laborActual { get; set; }
        public decimal? productBudget { get; set; }
        public decimal? productActual { get; set; }
        public EmployeeDto leadTech { get; set; }
    }
}
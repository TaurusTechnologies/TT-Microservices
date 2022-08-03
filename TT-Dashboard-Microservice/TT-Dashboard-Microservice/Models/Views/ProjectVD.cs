using System;
using System.Collections.Generic;
using System.Linq;
using TT_Dashboard_Microservice.Models.Dtos.Project;
using TT_Dashboard_Microservice.Models.Dtos.Employee;

namespace TT_Dashboard_Microservice.Models.Views
{

    public class ProjectProductFieldUpdateDto
    {
        public string field { get; set; }
        public string value { get; set; }

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
        public string contactName { get; set; }
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
        public bool hasServicePlan { get; set; }
        public string servicePlan { get; set; }
        public string leadTechnician { get; set; }
        public string programmer { get; set; }
        public decimal quote { get; set; }
        public decimal expenseApproved { get; set; }
        public decimal expensePending { get; set; }
        public decimal amountInvoiced { get; set; }
        public decimal amountOutstanding { get; set; }
        public decimal laborActual { get; set; }
        public string accountingStatus { get; set; }
        public string startDate { get; set; }
        public string completionDate { get; set; }
        public string dateDescription { get; set; }
    }

    public class ServicePlanDto
    {
        public int id { get; set; }
        public string provider { get; set; }
        public string plan { get; set; }
        public string expiration { get; set; }
    }

    public class ItemTroubleTicketDto
    {
        public int id { get; set; }
        public string title { get; set; }
        public string statusString { get; set; }
        public string dateCreated { get; set; }
        public string dateDue { get; set; }
        public string dateClosed { get; set; }
        public string assignedToList { get; set; }
    }

    public class InvoiceDto
    {
        public string id { get; set; }
        public decimal total { get; set; }
        public decimal appliedAmount { get; set; }
        public string timeCreated { get; set; }
        public string txnDate { get; set; }
        public decimal daysSinceInvoice { get; set; }
    }


    public class ProjectProductFieldUpdateResultDto
    {
        public bool success { get; set; }
        public string msg { get; set; }
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
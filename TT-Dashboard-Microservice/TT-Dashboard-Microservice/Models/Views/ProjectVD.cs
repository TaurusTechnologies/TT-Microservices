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

        /*             <div class="ng-hide" ng-hide="vm.isProjectDetailsHidden" style="padding: 0px">
                       <ul class="singleList">
                           <li ng-if="vm.currentUser.IsTech"><i class="{{vm.projectStatusIcon.icon}}" title="{{vm.projectStatusIcon.title}}"></i></li>
                           @if (Model.Project.LegacyServicePlan)
                           {
                               <li><b>Service Plan:</b> {{vm.project.ServicePlan.Name}}</li>
                           }
                           <li id="accountingStatus"><b>Accounting Status: </b>{{vm.project.ProjectAccountingStatu.Description}}</li>
                           <li><b>Lead Technician:</b> <span id="leadtech">{{vm.project.Employee.FullName}}</span></li>
                           <li><b>Programmer:</b> <span id="programmer">{{vm.project.ProgrammerTechnician.FullName}}</span></li>
                       </ul>
                       <ul ng-if="!vm.currentUser.IsTech" class="singleList">
                           <li ng-if="vm.project.LeadQuoteRevision"><b>Original Quote: </b><a href="/Lead/ViewQuoteRevision/{{vm.project.FromQuoteRevisionId}}?projectId={{vm.project.ProjectId}}">{{vm.project.LeadQuoteRevision.Name}}</a></li>
                           <li ng-if="vm.project.Lead"><b>Original Lead: </b><a href="/Lead/View/{{vm.project.FromLeadId}}">{{vm.project.Lead.Name}}</a></li>
                       </ul>
                       <ul ng-show="!vm.currentUser.IsTech || vm.currentUser.IsAdmin" class="singleList">
                           <li><b>Quote:</b> $@Model.RoomTotals.ToString("N2") @*{{vm.project.Budget | currency}}*@</li>
                           <li><b>Labor Quote:</b> {{vm.project.LaborBudget | currency}}</li>
                           <li><b>Labor Actual:</b><a href="/Project/LaborActuals/{{vm.project.ProjectId}}"> {{vm.laborActual | currency}}</a></li>
                           <li><b>Expense Quote:</b> {{vm.project.ExpenseBudget | currency}}</li>
                           <li>
                               <b>Expense Approved:</b>
                               <a href="/Project/ShowExpenses/{{vm.project.ProjectId}}?type=project&status=approved">{{vm.project.ExpenseApproved | currency}}</a>
                           <li>
                               <b>Expense Pending:</b>
                               <a href="/Project/ShowExpenses/{{vm.project.ProjectId}}?type=project&status=pending">{{vm.project.ExpensesPending | currency}}</a>
                           </li>
                           <li><b>Programming Quote:</b> {{vm.project.CodingBudget | currency}}</li>
                           <li>
                               <b>Programming Actual:</b>
                               <a href="/Project/ProgrammingActuals/{{vm.project.ProjectId}}"> {{vm.programmingActual | currency}}</a>
                           </li>
                           <li><b>Product Quote:</b> {{vm.project.ProductBudget | currency}}</li>
                           <li><b>Product Actual:</b> {{vm.productActual | currency}}</li>
                       </ul>
                       <ul class="singleList">
                           <li><b>Start Date:</b> @(Model.Start == null ? "" : Model.Start.Value.ToString("MM/dd/yyyy"))</li>
                           <li><b>End Date:</b> @(Model.Completion == null ? "" : Model.Completion.Value.ToString("MM/dd/yyyy"))</li>
                           @*<li><b>Completion Date:</b> {{vm.project.DueDate | amDateFormat: 'MM/DD/YYYY'}}</li>*@
                           <li><b>Amount Invoiced:</b> {{vm.AmountInvoiced | currency}}</li>
                           <li ng-show="!vm.currentUser.IsTech || vm.currentUser.IsAdmin"><b>Amount Outstanding:</b> {{vm.amountOutstanding | currency}}</li>
                       </ul>
                       <ul class="singleList" ng-if="vm.project.Status >= 3">
                           <li><b>Work Completed:</b> {{vm.project.DateWorkCompleted | amDateFormat: 'MM/DD/YYYY'}}</li>
                           <li><b>Service Plan:</b> {{vm.project.ServicePlan.Name}}</li>
                           <li><b>Service Plan Start:</b> {{vm.project.DateServicePlanStart | amDateFormat: 'MM/DD/YYYY'}}</li>
                           <li><b>Service Plan End:</b> {{vm.project.DateServicePlanEnd | amDateFormat: 'MM/DD/YYYY'}}</li>
                           <li><b>Expense Close:</b> {{vm.project.AccountingCloseDate | amDateFormat: 'MM/DD/YYYY'}}</li>
                       </ul>
                   </div>
       */

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
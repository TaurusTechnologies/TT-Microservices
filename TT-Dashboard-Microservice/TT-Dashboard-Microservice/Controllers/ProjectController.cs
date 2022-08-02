using System;
using System.Collections.Generic;
using System.Linq;
using AuthenticationandAuthorization.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TT_Dashboard_Microservice.Models;
using TT_Dashboard_Microservice.Models.Dtos;
using TT_Dashboard_Microservice.Models.Views;
using TT_Dashboard_Microservice.Models.Enums;

namespace TT_Dashboard_Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase // TODO: Switch to BaseController after testing.
    {
        private readonly DbContext _context;

        private readonly ILogger<ProjectController> _logger;

        public ProjectController(ILogger<ProjectController> logger, DbContext context)
        {
            _logger = logger;
            _context = context;
        }

        private decimal CalculateAmountInvoiced (string projectCode)
        {
            return _context.Qbinvoices.Where(x => x.Other == projectCode).Sum(x=>x.Total??0m);
        }

        private decimal CalculateAmountOutstanding (string projectCode)
        {
            return _context.Qbinvoices.Where(x => x.Other == projectCode).Sum(x => x.BalanceRemaining??0m);
        }

        private decimal? CalculateProductActualByProjectId(int projectId)
        {
            var productactual =
                _context.ProjectProducts.Where(
                    pp => pp.ProjectId == projectId && pp.OrderedByEmployeeId.HasValue && pp.Status == 1).Sum(pp => pp.Total) ?? 0.0m +
                    _context.ProjectMclproducts.Where(pp => pp.ProjectId == projectId && pp.OrderedByEmployeeId.HasValue).Sum(pp => pp.Total) ?? 0.0m;

            return productactual;
        }

        private ProjectDto FillInMetrics (ProjectDto p)
        {
            var project = _context.Projects.SingleOrDefault(x => x.ProjectId == p.projectId);
            var accountingStatus = _context.ProjectAccountingStatuses.SingleOrDefault(x => x.AccountingStatusId == project.AccountingStatusId);
            var servicePlan = project.ServicePlanId.HasValue ? _context.ServicePlans.SingleOrDefault(x => x.ServicePlanId == project.ServicePlanId) : null;
            var leadTechnician = _context.Employees.SingleOrDefault(x => x.EmployeeId == project.LeadTechnicianId);
            var programmer = _context.Employees.SingleOrDefault(x => x.EmployeeId == project.ProgrammerTechnicianId);
            var leadQuoteRevision = _context.LeadQuoteRevisions.SingleOrDefault(x => x.LeadQuoteRevisionId == project.FromQuoteRevisionId);
            var revisionRooms = _context.RevisionRooms.Where(x => x.LeadQuoteRevisionId == leadQuoteRevision.LeadQuoteRevisionId);
            var roomTotals = leadQuoteRevision != null
                ? revisionRooms.Where(x => x.Purchased).Sum(x => x.RoomTotals ?? 0)
                : 0.0m;


            p.metrics = new ProjectMetricsDto
            {
                accountingStatus = accountingStatus.Description,
                hasServicePlan = p.isLegacyServicePlan,
                servicePlan = servicePlan != null ? servicePlan.Name : "",  
                leadTechnician = leadTechnician != null ? leadTechnician.FullName : "",
                programmer = programmer != null ? programmer.FullName : "",
                quote = roomTotals,

                amountInvoiced = CalculateAmountInvoiced(project.ProjectCode),
                amountOutstanding = CalculateAmountOutstanding(project.ProjectCode),
            };

            return p;
        }

        /// <summary>
        ///     Get the Project object
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(Get))]
        public ProjectDto Get(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.ProjectId == id);
            if (project != null)
            {
                var start = _context.ProjectStartStopDates
                    .Where(x => x.ProjectId == project.ProjectId && x.StartDate != null)
                    .OrderBy(x => x.StartDate)
                    .FirstOrDefault();

                var end = _context.ProjectStartStopDates
                    .Where(x => x.ProjectId == project.ProjectId && x.EndDate != null)
                    .OrderByDescending(x => x.EndDate)
                    .FirstOrDefault();

                var customer = _context.Customers.SingleOrDefault(x => x.CustomerId == project.CustomerId);

                var leadQuoteRevision = _context.LeadQuoteRevisions.SingleOrDefault(x => x.LeadQuoteRevisionId == project.FromQuoteRevisionId);
                var leadQuote = _context.LeadQuotes.SingleOrDefault(x => x.LeadQuoteId == leadQuoteRevision.LeadQuoteId);

                decimal? laborTotal =
                    _context.TimeLogs.Where(
                        t => t.Activity.BillingType != null && (t.Activity.BillingType == (int)BillingType.Labor))
                        .Select(tl => tl.Hours * tl.Activity.BillableRate)
                        .Sum();

                decimal? codingTotal =
                    _context.TimeLogs.Where(
                        x => x.Activity.BillingType != null && (x.Activity.BillingType == (int)BillingType.Programming))
                        .Select(xl => xl.Hours * xl.Activity.BillableRate)
                        .Sum();

                var leadTechnician = _context.Employees.SingleOrDefault(x=>x.EmployeeId == project.LeadTechnicianId);

                var dto = new ProjectDto
                {
                    projectId = project.ProjectId,
                    name = project.Name,
                    start = start?.StartDate,
                    completion = end?.EndDate,
                    dateDescription = start?.Description,
                    jobNumber = project.ProjectCode,
                    poNumber = project.Ponumber,
                    cellNumber = project.CellPhone,
                    phoneNumber = project.PhoneNumber,
                    faxNumber = project.FaxNumber,
                    contactName = project.ContactName,
                    contactEmail = project.Email,
                    isLegacyServicePlan = project.LegacyServicePlan ?? true,

                    installAddress = new ProjectLocationDto
                    {
                        address1 = project.Address1,
                        address2 = project.Address2,
                        city = project.City,
                        state = project.State,
                        zip = project.Zip
                    },

                    shippingAddress = new ProjectLocationDto
                    {
                        locationName = leadQuote.ShippingLocationName,
                        address1 = leadQuote.ShippingAddress1,
                        address2 = leadQuote.ShippingAddress2,
                        city = leadQuote.ShippingCity,
                        state = leadQuote.ShippingState,
                        zip = leadQuote.ShippingZip
                    },

                    billingName = customer.BillingContactName,
                    billingEmail = customer.BillingEmail,

                    billingAddress = new ProjectLocationDto
                    {
                        address1 = leadQuote.BillingAddress1,
                        address2 = leadQuote.BillingAddress2,
                        city = leadQuote.BillingCity,
                        state = leadQuote.BillingState,
                        zip = leadQuote.BillingZip
                    },

                    customer = new ProjectCustomerDto
                    {
                        customerId = project.CustomerId,
                        name = customer != null ? customer.ContactName : "",
                    },

                    notes = project.Notes,

                    startStopDates = _context.ProjectStartStopDates.Where(x => x.ProjectId == project.ProjectId)
                        .Select(x => new ProjectStartStopDateDto
                        {
                            ProjectId = x.ProjectId, StartDate = x.StartDate, EndDate = x.EndDate,
                            Description = x.Description, ProjectStartStopDateId = x.ProjectStartStopDateId
                        }).ToList(),


                    laborBudget = project.LaborBudget,
                    laborActual = laborTotal,
                    expenseBudget = project.ExpenseBudget,
                    codingBudget = project.CodingBudget,
                    codingActual = codingTotal,
                    productBudget = project.ProductBudget,

                    leadTech = project.LeadTechnicianId.HasValue ? new EmployeeDto
                    {
                        employeeId = project.LeadTechnicianId.Value,
                        fullName = leadTechnician.FullName
                    } : null
                };

                dto = FillInMetrics(dto);
                return dto;
            }

            _logger.LogWarning("[Project/Get]: " + id + " not found");
            return null;
        }


        [HttpPost("projectproduct/{id}/field")]
        public ProjectProductFieldUpdateResultDto UpdateProductField (int id, ProjectProductFieldUpdateDto dto)
        {
            try
            {
                 var projectProduct = _context.ProjectProducts
                    .Single(x => x.ProjectProductId == id);

                // map the fields.
                switch (dto.field)
                {
                    case "ordernotes":
                        {
                            projectProduct.OrderNotes = dto.value;
                            break;
                        }
                    case "description":
                        {
                            projectProduct.Description = dto.value;
                            break;
                        }
                }

                // update the database.
                _context.SaveChanges();

                return new ProjectProductFieldUpdateResultDto
                {
                    success = true
                };
            } 
            catch (Exception e)
            {
                return new ProjectProductFieldUpdateResultDto { success = false, msg = e.Message };
            }

        }

        private static string DisplayName (Employee e)
        {
            return e.IsActive ? e.FullName : string.Format("{0} (Inactive)", e.FullName);

        }

        [HttpGet("invoices/{id}")]
        public IList<InvoiceDto> GetInvoices(int id)
        {
            var p = _context.Projects.SingleOrDefault(l => l.ProjectId == id);
            var invoices = _context.Qbinvoices.Where(x => x.Other == p.ProjectCode);

            return invoices.Select(x => new InvoiceDto
            {
                id = x.TxnId,
                appliedAmount = Math.Abs(x.AppliedAmount ?? 0m),
                timeCreated = x.TimeCreated.Value.ToShortDateString(),
                total = x.Total ?? 0m,
                daysSinceInvoice = (DateTime.Now - (x.TxnDate ?? DateTime.Now)).Days,
                txnDate = x.TxnDate.ToString()
            }).ToList();
        }

        [HttpGet("serviceplans/{id}")]
        public IList<ServicePlanDto> GetServicePlans(int id)
        {
            var p = _context.Projects.SingleOrDefault(l => l.ProjectId == id);
            var invoices = _context.Qbinvoices.Where(x => x.Other == p.ProjectCode);
            var list = new List<ServicePlanDto>();

            if (p.ServicePlanId.HasValue)
            {
                var plan = _context.ServicePlans.SingleOrDefault(x => x.ServicePlanId == p.ServicePlanId);
                list.Add(
                    new ServicePlanDto
                    {
                        id = plan.ServicePlanId,
                        provider = "Taurus",
                        plan = plan.Name,
                        expiration = plan.DurationDays + " days"
                    });
            }

            var thirdParty = _context.ThirdPartySupportContracts
                .Where(x => x.ProjectId == id)
                .OrderBy(x=>x.Description)
                .Select (x=>new ServicePlanDto
                {
                    id = x.ThirdPartySupportContractId,
                    provider = x.Provider,
                    plan = x.Description,
                    expiration = x.ExpirationDate != null ? x.ExpirationDate.Value.ToShortDateString() : ""
                }).ToList();

            list.AddRange(thirdParty);
            return list;
        }

        [HttpGet("itemtroubleticket/{id}")]

        public IList<ItemTroubleTicketDto> GetTroubleTickets(int id)
        {
            var tickets = _context.TroubleTickets.Where(x => x.ProjectId == id);
            return tickets.Select(x => new ItemTroubleTicketDto
            {
                id=x.TroubleTicketId,
                title = x.Title,
                statusString = x.Status.ToString(),
                dateCreated = x.DateCreated.ToShortDateString(),
                dateDue = x.DateDue.HasValue ? x.DateDue.Value.ToShortDateString() : "",
                dateClosed = x.DateClosed.HasValue ? x.DateClosed.Value.ToShortDateString() : "",
//                assignedToList = x.TroubleTicketAssignments.ToString()
                assignedToList = ""         // TODO - need to grab this!
            }).ToList();
        }

        [HttpGet("itemhistory/{id}")]
        public IList<ItemHistoryDto> GetComments(int id)
        {
            var p = _context.Projects.SingleOrDefault(l => l.ProjectId == id);
            if (p != null)
            {
                var itemComments = _context.ItemComments.Where(x => x.ProjectId == id);
                var itemFiles = _context.ItemFiles.Where(x => x.ProjectId == id);

                var histories =
                    itemComments.Select(
                        ic =>
                        new ItemHistoryDto
                        {
                            author = DisplayName(ic.Employee),
                            authorId = ic.EmployeeId,
                            id = ic.ItemCommentId,
                            message = ic.Message,
                            timeStamp = ic.Timestamp.ToString(),
                            type = ic.Type
                        }).AsEnumerable();

                histories = histories.Union(
                    itemFiles.Select(
                        iff =>
                        new ItemHistoryDto
                        {
                            author = DisplayName(iff.Employee),
                            authorId = iff.EmployeeId,
                            id = iff.ItemFileId,
                            message = string.Format("{0} Uploaded", iff.Name),
                            timeStamp = iff.Timestamp.ToString(),
                            type = (int)ItemHistoryType.FileUpload
                        })).OrderByDescending(t => t.timeStamp);
 
                return histories.ToList();
            }
            return null;
    }


    [HttpGet("rooms/{id}")]
        public IList<ProjectRoomDto> GetRooms(int id)
        {
            var projectRooms = _context.ProjectRooms
                .Where(x => x.ProjectId == id && !x.Room.IsDeleted.Value)
                .Select(x=>new ProjectRoomDto
                {
                    projectRoomId = x.ProjectRoomId,
                    roomId = x.RoomId,
                    roomName = x.Room.RoomName,
                    isActive = x.IsActive??false,
                })
                .ToList();

            foreach (var pr in projectRooms)
            {
                var products = _context.ProjectProducts
                    .Where(x => x.ProjectRoomId == pr.projectRoomId && x.SuppliedByOther == false);

                var removed = new List<ProjectProduct>();
                var received = new List<ProjectProduct>();
                var ordered = new List<ProjectProduct>();
                var unOrdered = new List<ProjectProduct>();

                foreach (var product in products)
                {
                    if (product.Status == 0)
                    {
                        removed.Add(product);
                    } 
                    else if (product.ProjectProductReceiveds.Sum(x=>x.QuantityReceived) >= product.Quantity)
                    {
                        received.Add(product);
                    } 
                    else if (product.OrderedOn.HasValue)
                    {
                        ordered.Add(product);
                    }
                    else
                    {
                        unOrdered.Add(product);
                    }
                }

                // Sort them in the proper order.
                var concat = new List<ProjectProduct>();
                concat.AddRange(ordered);
                concat.AddRange(unOrdered);
                concat.AddRange(received);
                concat.AddRange(removed);

                pr.products = products.Select( x=>new ProjectProductDto
                {
                    received = x.ReceivedOn.HasValue,
                    projectProductId = x.ProjectProductId,
                    description = x.Description,
                    status = x.Status,
                    quantity = x.Quantity,
                    binNumber = x.BinNumber,
                    vendor = x.Vendor,
                    trackingNumber = x.TrackingNumber,
                    price = x.Price,
                    quotePrice = x.QuotePrice,
                    manufacturer = x.Manufacturer,
                    partNumber = x.PartNumber,
                    eta = x.Eta,
                    poNumber = x.Ponumber,
                    orderNotes = x.OrderNotes
                }).ToList();
            }

            return projectRooms;
        }
    }

}
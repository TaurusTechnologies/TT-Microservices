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

        public decimal? CalculateProductActualByProjectId(int projectId)
        {
            var productactual =
                _context.ProjectProducts.Where(
                    pp => pp.ProjectId == projectId && pp.OrderedByEmployeeId.HasValue && pp.Status == 1).Sum(pp => pp.Total) ?? 0.0m +
                    _context.ProjectMclproducts.Where(pp => pp.ProjectId == projectId && pp.OrderedByEmployeeId.HasValue).Sum(pp => pp.Total) ?? 0.0m;

            return productactual;
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

                return new ProjectDto
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
                    isLegacyServicePlan = project.LegacyServicePlan??true,

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

                    customer = customer != null ? new ProjectCustomerDto
                    {
                        customerId = project.CustomerId,
                        customerName = customer.ContactName,
                    } : null,

                    notes = project.Notes,

                    startStopDates = _context.ProjectStartStopDates.Where(x => x.ProjectId == project.ProjectId)
                        .Select(x => new ProjectStartStopDateDto
                        {
                            ProjectId = x.ProjectId, StartDate = x.StartDate, EndDate = x.EndDate,
                            Description = x.Description, ProjectStartStopDateId = x.ProjectStartStopDateId
                        }).ToList(),

                    metrics = new ProjectMetricsDto
                    {

                    },

                    laborBudget = project.LaborBudget,
                    laborActual = laborTotal,
                    expenseBudget = project.ExpenseBudget,
                    codingBudget = project.CodingBudget,
                    codingActual = codingTotal,
                    productBudget = project.ProductBudget
                };
            }

            _logger.LogWarning("[Project/Get]: " + id + " not found");
            return null;
        }

        public class ProjectProductFieldUpdateResultDto
        {
            public bool success { get; set; }
            public string msg { get; set; }
        }

        [HttpPost("projectproduct/{id}/field")]
        public ProjectProductFieldUpdateResultDto UpdateProjectProductField (int id, ProjectProductFieldUpdateDto dto)
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

        [HttpGet("rooms/{id}")]
        public IList<ProjectRoomDto> GetProjectRooms(int id)
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
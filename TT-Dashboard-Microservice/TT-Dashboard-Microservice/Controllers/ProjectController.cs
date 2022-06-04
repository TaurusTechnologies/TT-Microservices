using System;
using System.Collections.Generic;
using System.Linq;
using AuthenticationandAuthorization.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TT_Dashboard_Microservice.Models;
using TT_Dashboard_Microservice.Models.Dtos;
using TT_Dashboard_Microservice.Models.Views;

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
                    contactName = project.ContactName,
                    contactEmail = project.Email,

                    customer = customer != null ? new ProjectCustomerDto
                    {
                        customerId = project.CustomerId,
                        customerName = customer.ContactName,
                    } : null,
                    startStopDates = _context.ProjectStartStopDates.Where(x => x.ProjectId == project.ProjectId)
                        .Select(x => new ProjectStartStopDateDto
                        {
                            ProjectId = x.ProjectId, StartDate = x.StartDate, EndDate = x.EndDate,
                            Description = x.Description, ProjectStartStopDateId = x.ProjectStartStopDateId
                        }).ToList()
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
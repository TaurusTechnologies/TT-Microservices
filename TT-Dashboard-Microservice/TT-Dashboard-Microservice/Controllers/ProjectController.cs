using System.Linq;
using AuthenticationandAuthorization.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TT_Dashboard_Microservice.Models;
using TT_Dashboard_Microservice.Models.Views;

namespace TT_Dashboard_Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : BaseController
    {
        private readonly DbContext _context;

        private readonly ILogger<ProjectController> _logger;

        public ProjectController(ILogger<ProjectController> logger, DbContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        ///     Test the string
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(Get))]
        public ProjectVD Get(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.ProjectId == id);
            if (project != null)
            {
                //var currentUser = LoggedInUser.CurrentUser.ToViewModel();
                //currentUser.InProcurementTeam = DataContext.Projects.Any(
                //            p => p.ProjectId == id && DataContext.Employees.Any(
                //                e => e.EmployeeId == p.CreatedById && DataContext.TeamMembers.Any(
                //                    t => t.TeamId == e.PurchaseTeamId && t.EmployeeId == LoggedInUser.CurrentUser.EmployeeId)));

                var start = _context.ProjectStartStopDates
                    .Where(x => x.ProjectId == project.ProjectId && x.StartDate != null)
                    .OrderBy(x => x.StartDate)
                    .FirstOrDefault();

                var end = _context.ProjectStartStopDates
                    .Where(x => x.ProjectId == project.ProjectId && x.EndDate != null)
                    .OrderByDescending(x => x.EndDate)
                    .FirstOrDefault();

                var vd = new ProjectVD
                {
                    Project = project,
                    //CurrentUser = LoggedInUser.CurrentUser.ToViewModel(),
                    StartStopDates = _context.ProjectStartStopDates.Where(x => x.ProjectId == project.ProjectId)
                        .ToList()
                };

                if (start != null)
                {
                    if (start.StartDate != null)
                    {
                        vd.Start = start.StartDate;
                    }

                    vd.DateDescription = start.Description;
                }

                if (end != null)
                {
                    if (end.EndDate != null)
                    {
                        vd.Completion = end.EndDate;
                    }
                }

                return vd;
            }

            _logger.LogWarning("[Project/Get]: " + id + " not found");
            return null;
        }

    }
}
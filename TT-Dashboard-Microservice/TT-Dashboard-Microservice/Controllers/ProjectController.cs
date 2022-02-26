using System.Linq;
using AuthenticationandAuthorization.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TT_Dashboard_Microservice.Models;

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
        public string Get()
        {
            var test = _context.Projects.FirstOrDefault(x => x.IsInvoiced == true);
            return test?.Name;
        }
    }
}
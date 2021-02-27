using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POC.Middleware.AppInsights.Model;
using System.Net.Mime;

namespace POC.Middleware.AppInsights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        //Query on Log Analytics
        //requests
        //| where name startswith "POST"
        //| order by timestamp
        //| project timestamp, customDimensions.RequestBody

        private readonly ILogger logger;

        public ClientController(ILoggerFactory loggerFactory)
        {
            this.logger = loggerFactory.CreateLogger<ClientController>();
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult Index([FromBody] Client client)
        {
            return Ok(client);
        }
    }
}

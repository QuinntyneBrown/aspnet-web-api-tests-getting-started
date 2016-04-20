using Chloe.Api.Services.Contracts;
using System.Web.Http;

namespace Chloe.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public EmployeeController()
        {

        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        protected readonly IEmployeeService employeeService;
    }
}

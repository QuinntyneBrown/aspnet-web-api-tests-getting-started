using Chloe.Api.Services.Contracts;
using System.Web.Http;

namespace Chloe.Api.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        [Route("get")]
        public IHttpActionResult Get()
        {
            return Ok(this.employeeService.Get());
        }

        protected readonly IEmployeeService employeeService;
    }
}

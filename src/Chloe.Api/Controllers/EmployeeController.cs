using System.Web.Http;

namespace Chloe.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}

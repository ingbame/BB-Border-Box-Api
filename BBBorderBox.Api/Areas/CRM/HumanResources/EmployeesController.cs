using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBBorderBox.Api.Areas.CRM.HumanResources
{
    [Area("CRM")]
    [Route("api/[area]/HumanResources/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public  ActionResult GetEmployee()
        {
            return Ok();
        }
    }
}

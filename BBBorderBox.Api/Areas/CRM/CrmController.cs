using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBBorderBox.Api.Areas.CRM
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetCRM()
        {
            return Ok();
        }
    }
}

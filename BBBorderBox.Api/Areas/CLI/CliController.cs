using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBBorderBox.Api.Areas.CLI
{
    [Area("CLI")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class CliController : ControllerBase
    {
    }
}

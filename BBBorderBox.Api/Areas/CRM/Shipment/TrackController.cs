using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBBorderBox.Api.Areas.CRM.Shipment
{
    [Area("CRM")]
    [Route("api/[area]/Shipment/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        [HttpGet("{TrackingNumbers}")]
        public async Task<ActionResult> GetTrack(string TrackingNumbers)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-eu.dhl.com/track/shipments?trackingNumber={TrackingNumbers}"),
                Headers = {
                    { "DHL-API-Key", "LJhPQQ1e1M7r3hVAtwpfQZGn83ISiGVK" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(body);
                return Ok(body);
            }
        }
        [HttpGet("LogisticType/{LogisticType}")]
        public async Task<ActionResult> GetLogisticType(string LogisticType)
        {
            return Ok("DHL");
        }
    }
}

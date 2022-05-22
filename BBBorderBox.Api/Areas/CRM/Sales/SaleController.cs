using BBBorderBox.Core.CRM.Sales;
using BBBorderBox.Entity.Data.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Api.Areas.CRM.Sales
{
    [Area("CRM")]
    [Route("api/[area]/Sales/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSale(long id)
        {
            var consult = await BoSale.Instance.GetSale(id);

            if (consult == null)
                return NotFound();
            return consult;
        }
        [HttpPost]
        public async Task<ActionResult> PostSale(Sale model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                model = await BoSale.Instance.PostBotIntegrationAsync(model);
                return CreatedAtAction("GetSale", new { id = model.SaleId }, model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw; //500
            }
        }
    }
}

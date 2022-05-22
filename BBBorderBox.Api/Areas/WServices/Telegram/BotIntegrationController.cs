using BBBorderBox.Entity.Data.Telegram;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BBBorderBox.Core.WServices.Telegram;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Api.Areas.WServices.Telegram
{
    [Area("WServices")]
    [Route("api/[area]/Telegram/[controller]")]
    [ApiController]
    public class BotIntegrationController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<ChatUpdate>> GetBotUpdate(long id)
        {
            var consult = await BotIntegration.Instance.GetBotUpdate(id);

            if (consult == null)
                return NotFound();
            return consult;
        }
        [HttpPost]
        public async Task<ActionResult> PostBotUpdate(ChatUpdate model)
        {
            try
            {
                if (model == null || model.UpdateId == 0)
                    return BadRequest();
                model = await BotIntegration.Instance.PostBotIntegrationAsync(model);
                return CreatedAtAction("GetBotUpdate", new { id = model.UpdateId }, model);
            }
            catch (DbUpdateConcurrencyException es)
            {
                throw; //500
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BBBorderBox.Api.Data;
using BBBorderBox.Api.Models;

namespace BBBorderBox.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaquetesController : ControllerBase
    {
        private readonly PaqueteriaContext _context;
        public PaquetesController(PaqueteriaContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSale(long id)
        {
            //var _sale = await _context.Sales.FindAsync(id);
            //var _sale2 = _context.Set<Sale>().FromSqlRaw("dbo.EjemploSP @P01",id);

            //if (_sale == null)
            //    return NotFound();
            //return _sale;
            return new Sale();
        }        
        [HttpGet]
        public async Task<IEnumerable<Sale>> GetSales()
        {
            //return await _context.Sales.ToListAsync();
            return new Sale[0];
        }
        [HttpPost]
        public async Task<ActionResult<Sale>> PostSale(Sale _model)
        {
            if (_model == null)
                return BadRequest();
            //await _context.Sales.AddAsync(_model);
            //await _context.SaveChangesAsync();

            return CreatedAtAction("GetSale", new { id = _model.SaleId }, _model);
        }
        [HttpPut]
        public async Task<ActionResult<Sale>> PutSale(long id, Sale body)
        {
            if (id != body.SaleId)
                return BadRequest(); //400
            //_context.Entry(body).State = EntityState.Modified;
            try
            {
                //await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!await _context.Sales.AnyAsync(e => e.SaleId == id))
                //    return NotFound(); //404
                //else
                //    throw; //500
            }
            return NoContent(); //204 se usa regularmente con los puts, las ediciones
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sale>> DeleteSale(long id)
        {
            //var _sale = await _context.Sales.FindAsync(id);
            //if (_sale == null)
            //    return NotFound();
            //_context.Sales.Remove(_sale);
            //await _context.SaveChangesAsync();
            //return _sale;
            return new Sale();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Policlinico_La_Familia.Contexto;
using Policlinico_La_Familia.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Policlinico_La_Familia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly CentroSaludFamiliaContext _context;
        public FacturaController(CentroSaludFamiliaContext context)
        {
            _context = context;
        }
        // GET: api/<FacturaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Receta>>> GetFactura()
        {
            return await _context.Recetas.ToListAsync();
        }
        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Factura>> GetFactura(int id)
        {
            return await _context.Facturas.FirstOrDefaultAsync(x => x.Idfactura == id);
        }

        // POST api/<FacturaController>
        [HttpPost]
        public async Task<ActionResult> Post(Factura factura)
        {
            if (factura != null)
            {
                _context.Facturas.Add(factura);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("ingrese datos validos"); }
        }

        // PUT api/<FacturaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutFactura(int id, string FechaEmision, int montototal, Factura factura)
        {
            Factura modFactura = await _context.Facturas.SingleOrDefaultAsync(x => x.Idfactura == id);
            if (modFactura != null)
            {
                modFactura.FechaEmision = factura.FechaEmision;
                modFactura.MontoTotal = factura.MontoTotal;

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            { return NotFound(); }
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Factura facturaEliminar = await _context.Facturas.SingleOrDefaultAsync(x => x.Idfactura == id);
            if (facturaEliminar != null)
            {
                _context.Remove(facturaEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            { return NotFound(); }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Policlinico_La_Familia.Contexto;
using Policlinico_La_Familia.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Policlinico_La_Familia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetasController : ControllerBase
    {
        private readonly CentroSaludFamiliaContext _context;
        public RecetasController(CentroSaludFamiliaContext context)
        {
            _context = context;
        }
        // GET: api/<RecetasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Receta>>> GetPacientes()
        {
            return await _context.Recetas.ToListAsync();
        }
        // GET api/<RecetasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Receta>> Get(int id)
        {
            return await _context.Recetas.FirstOrDefaultAsync(x => x.Idreceta == id);
        }

        // POST api/<MarcaController>
        [HttpPost]
        public async Task<ActionResult> Post(Receta marca)
        {
            if (marca != null)
            {
                _context.Recetas.Add(marca);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("ingrese datos validos"); }
        }

        // POST api/<RecetasController>
        [HttpPost]
        public async Task<ActionResult> PostReceta(Receta receta)
        {
            if (receta != null)
            {
                _context.Recetas.Add(receta);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("ingrese datos validos"); }
        }

        // PUT api/<RecetasController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Receta receta)
        {
            Receta marcaModificar = await _context.Recetas.SingleOrDefaultAsync(x => x.Idreceta == id);
            if (marcaModificar != null)
            {
                marcaModificar.Dosificación = receta.Dosificación;
                marcaModificar.Instrucciones = receta.Instrucciones;

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            { return NotFound(); }
        }
        // DELETE api/<RecetasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Receta recetaEliminar = await _context.Recetas.SingleOrDefaultAsync(x => x.Idreceta == id);
            if (recetaEliminar != null)
            {
                _context.Remove(recetaEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            { return NotFound(); }
        }
    }
}

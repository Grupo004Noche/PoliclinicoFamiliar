using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Policlinico_La_Familia.Contexto;
using Policlinico_La_Familia.Modelos;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Policlinico_La_Familia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly CentroSaludFamiliaContext _context;
        public MedicoController(CentroSaludFamiliaContext context)
        {
            _context = context;
        }

        // GET: api/<MedicoController>
        [HttpGet]
        public async Task<ActionResult<List<Medico>>> Get()
        {
            return await _context.Medicos.ToListAsync();
        }

        [HttpGet("Reporte1")]
        public async Task<ActionResult<List<reporte1>>> ListaMedico()
        {
            return await _context.Medicos.Select(x => new reporte1
            {
                IDMedico = x.Idmédico,
                Nombre = x.Nombre,
                Especialidad= x.Especialidad,
                Telefono=x.Telefono,
            }).ToListAsync();
        }

        // GET api/<MedicoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MedicoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MedicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class reporte1
    {
        public int IDMedico { get; set; }
        public string? Nombre { get; set; }
        public string? Especialidad { get; set; }
        public string? Telefono {  get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Policlinico_La_Familia.Contexto;
using Policlinico_La_Familia.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Policlinico_La_Familia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialesMedicoController : CentroSaludFamiliaContext
    {
        private readonly CentroSaludFamiliaContext _context;
        public HistorialesMedicoController(CentroSaludFamiliaContext context)
        {
            _context = context;
        }
        // GET: api/<HistorialesMedicoController>
        [HttpGet]
        public async Task<ActionResult<List<HistorialesMedico>>> Get()
        {
            return await _context.HistorialesMedicos.ToListAsync();
        }
        // GET api/<HistorialesMedicoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HistorialesMedicoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HistorialesMedicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HistorialesMedicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

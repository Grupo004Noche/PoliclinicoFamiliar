using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClientPoliclinicoLaFamilia.Models;

namespace ClientPoliclinicoLaFamilia.Data
{
    public class ClientPoliclinicoLaFamiliaContext : DbContext
    {
        public ClientPoliclinicoLaFamiliaContext (DbContextOptions<ClientPoliclinicoLaFamiliaContext> options)
            : base(options)
        {
        }

        public DbSet<ClientPoliclinicoLaFamilia.Models.Paciente> Paciente { get; set; } = default!;
        public DbSet<ClientPoliclinicoLaFamilia.Models.Medico> Medico { get; set; } = default!;
        public DbSet<ClientPoliclinicoLaFamilia.Models.Cita> Cita { get; set; } = default!;
    }
}

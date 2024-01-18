using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClientPoliclinicoLaFamilia.Models
{
    public class Medico
    {
        [Key]
        [Column("IDMédico")]
        public int Idmédico { get; set; }

        [StringLength(100)]
        [Unicode(false)]
        public string? Nombre { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string? Especialidad { get; set; }

        [StringLength(20)]
        [Unicode(false)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        [Unicode(false)]
        public string? CorreoElectronico { get; set; }
 }
}

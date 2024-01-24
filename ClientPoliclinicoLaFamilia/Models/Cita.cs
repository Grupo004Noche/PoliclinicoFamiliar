using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClientPoliclinicoLaFamilia.Models
{
    public class Cita
    {
        [Key]
        [Column("IDCita")]
        public int Idcita { get; set; }

        [Column("IDPaciente")]
        public int? Idpaciente { get; set; }

        [Column("IDMédico")]
        public int? Idmédico { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraCita { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Motivo { get; set; }

        [StringLength(20)]
        [Unicode(false)]
        public string? EstadoCita { get; set; }
    }
}

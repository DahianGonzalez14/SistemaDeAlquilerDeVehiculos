using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    [Table("Madre")]
    class Madre
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(2)]
        [Column(TypeName = "varchar")]
        public string Estatus { get; set; }
        public bool Borrado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}

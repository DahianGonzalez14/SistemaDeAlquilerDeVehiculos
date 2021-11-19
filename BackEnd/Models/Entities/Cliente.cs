using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    [Table("Cliente")]
    class Cliente
    {
        [Required]
        public int clienteId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Nombre { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Apellido { get; set; }
        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string Direccion { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string Telefono { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string  Correo { get; set; }

        [MaxLength(11)]
        [Column(TypeName = "varchar")]
        public string Cedula { get; set; }

        public List<Madre> MadreId { get; set; }


    }
}

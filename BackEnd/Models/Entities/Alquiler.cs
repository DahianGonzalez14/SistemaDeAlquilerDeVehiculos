using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    [Table("Alquiler")]
    class Alquiler
    {
        [Required]
        public int AlquilerId { get; set; }
        public List<Cliente> ClienteId { get; set; }
        public List<Vehiculo> VehiculoId { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string MetodoPago { get; set; }

        [MaxLength(20)]
        
        public decimal Costo { get; set; }

        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        [MaxLength(20)]
        public decimal Penalidad { get; set; }
        public List<Madre> MadreId { get; set; }


    }
}

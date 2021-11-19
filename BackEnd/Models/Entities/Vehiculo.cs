using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    [Table("Vehiculo")]
    class Vehiculo
    {
        [Required]
        public int AlquilerId { get; set; }
        public List<TipoTransmision> TransId { get; set; }
        public List<TipoCombustible> CombusId { get; set; }

        public List<Modelo> ModeloId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Chasis { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string Placa { get; set; }

        [MaxLength(4)]
        [Column(TypeName = "varchar")]
        public string Anio { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string Color { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string Cilindraje { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string KilometrosTablero { get; set; }

        public int CantidadPuerta { get; set; }

        public decimal Precio { get; set; }
        public List<Madre> MadreId { get; set; }

    }
}

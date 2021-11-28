using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    public class Alquiler : Base
    {
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public string MetodoPago { get; set; }
        public decimal Costo { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public decimal Penalidad { get; set; }
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }

    }
}

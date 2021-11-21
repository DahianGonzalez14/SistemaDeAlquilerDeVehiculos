using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    public class Vehiculo : Base
    {
        public int TipoTransmisionId { get; set; }
        public int TipoCombustibleId { get; set; }
        public int ModeloId { get; set; }
        public string Chasis { get;set; }
        public string Placa { get; set; }   
        public string Anio { get; set; }
        public string Color { get; set; }
        public string Cilindraje { get; set; }  
        public string KilometrosTablero { get; set; }
        public int CantidadPuerta { get; set; }
        public decimal Precio { get; set; }
        public TipoTransmision TipoTransmision { get; set; }
        public TipoCombustible TipoCombustible { get; set; }
        public Modelo Modelo { get; set; }  
        public List<Alquiler> Alquileres { get; set; }
    }
}

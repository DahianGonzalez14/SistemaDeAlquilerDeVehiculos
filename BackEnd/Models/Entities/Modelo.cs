using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    public class Modelo : Base
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        public Marca Marca { get; set; }    
        public List<Vehiculo> Vehiculos { get; set; }
    }
}

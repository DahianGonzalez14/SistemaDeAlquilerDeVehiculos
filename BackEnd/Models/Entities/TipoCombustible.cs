using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    public class TipoCombustible : Base
    {
        public string Nombre { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }   

    }
}

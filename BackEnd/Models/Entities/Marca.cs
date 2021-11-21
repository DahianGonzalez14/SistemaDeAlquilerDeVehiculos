using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    public class Marca : Base
    {
        public string Nombre { get; set; }
        public List<Modelo> Modelos { get; set; }

    }
}

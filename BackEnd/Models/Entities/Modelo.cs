﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{

    [Table("Modeelo")]
    class Modelo
    {
        [Required]
        public int ModeloId { get; set; }
        public List<Marca> MacaId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Nombre { get; set; }
        public List<Madre> MadreId { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    [Table("Marca")]
    class Marca
    {
        [Required]
        public int MarcaId { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Nombre { get; set; }

        public List<Madre> MadreId { get; set; }

    }
}

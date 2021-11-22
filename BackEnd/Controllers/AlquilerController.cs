using SegundoParcial.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Controllers
{
    public class AlquilerController
    {
        AlquilerRepository alquilerRepository;
        public AlquilerController()
        {
            alquilerRepository = new AlquilerRepository();
        }

        public List<Alquiler> getAll()
        {
            return alquilerRepository.GetAll();
        }

        public Alquiler findById(int id)
        {
            return alquilerRepository.FindById(id);
        }
        //faltan los metodos de crear, editar y eliminar
    }
}

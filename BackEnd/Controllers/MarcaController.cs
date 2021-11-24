using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoParcial.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Implementations;
namespace SistemaDeAlquilerDeVehiculos.BackEnd.Controllers
{
  
    public class MarcaController

    {
        MarcaRepository marcaRepository;
        public MarcaController()
        {
            marcaRepository = new MarcaRepository();
        }

        public List<Marca> getAll()
        {
            return marcaRepository.GetAll();
        }

        public Marca findById(int id)
        {
            return marcaRepository.FindById(id);
        }

        public OperationResult Create(Marca marca)
        {
            var existMarca = marcaRepository.Find(x => x.Nombre.Equals(marca.Nombre));
            if (existMarca == null)
            {
                return new OperationResult() { Data = null, Message = "Error modelo existente", Success = false };

            }
            var createdMarca = marcaRepository.Create(marca);

            return new OperationResult() { Data = createdMarca, Message = "Marca creado satisfatoria mente", Success = true };
        }

        public OperationResult Edit(Marca marca)
        {
            var existMarca = marcaRepository.Find(x => x.Nombre.Equals(marca.Nombre));
            if (existMarca != null)
            {
                return marcaRepository.Update(marca);
            }
            return new OperationResult() { Data = null, Message = "Error existe una transmicion con dicho nombre", Success = false };
        }

        public OperationResult Delete(Marca marca)
        {
            return marcaRepository.Delete(marca.Id);
        }


    }
}

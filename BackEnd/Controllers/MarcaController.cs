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
            var existsMarca = marcaRepository.Find(x => x.Nombre.Equals(marca.Nombre) && x.Borrado == false);
            if (existsMarca != null)
            {
                return new OperationResult() { Data = null, Message = "Error marca existente", Success = false };
            }

            var createdMarca = marcaRepository.Create(marca);
            return new OperationResult() { Data = createdMarca, Message = "Marca creada satisfatoriamente", Success = true };
        }

        public OperationResult Edit(Marca marca)
        {
            var existMarca = marcaRepository.Find(x => x.Id.Equals(marca.Id) && x.Borrado == false);
            if (existMarca != null && existMarca.Id == marca.Id)
            {
                existMarca.Nombre = marca.Nombre;
                existMarca.FechaModificacion = DateTime.Now;

                return marcaRepository.Update(existMarca);
            }
            return new OperationResult() { Data = null, Message = "Error existe una marca con dicho nombre", Success = false };
        }

        public OperationResult Delete(Marca marca)
        {
            return marcaRepository.Delete(marca.Id);
        }


    }
}

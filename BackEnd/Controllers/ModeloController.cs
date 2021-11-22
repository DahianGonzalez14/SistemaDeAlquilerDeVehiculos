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
    public class ModeloController
    {
        ModeloRepository modeloRepository;
        public ModeloController()
        {
            modeloRepository = new ModeloRepository();
        }

        public List<Modelo> getAll()
        {
            return modeloRepository.GetAll();
        }

        public Modelo findById(int id)
        {
            return modeloRepository.FindById(id);
        }

        public OperationResult Create(Modelo modelo)
        {
            var existsModelo = modeloRepository.Find(x => x.Nombre.Equals(modelo.Nombre) && x.MarcaId == modelo.MarcaId);

            if (existsModelo == null)
            {
                return new OperationResult() { Data = null, Message = "Error modelo existente", Success = false };
            }

            var createdModelo = modeloRepository.Create(modelo);
            return new OperationResult() { Data = createdModelo, Message = "Modelo creado satisfactoriamente", Success = true };
        }

        public OperationResult Edit(Modelo modelo)
        {
            var existsModelo = modeloRepository.Find(x => x.Nombre.Equals(modelo.Nombre) && x.MarcaId == modelo.MarcaId);
            if (existsModelo != null || existsModelo.Id == modelo.Id)
            {
                return modeloRepository.Update(modelo);
            }
            return new OperationResult() { Data = null, Message = "Error existe un modelo con dicho nombre", Success = false };
        }

        public OperationResult Delete(Modelo modelo)
        {
            return modeloRepository.Delete(modelo.Id);
        }
    }
}

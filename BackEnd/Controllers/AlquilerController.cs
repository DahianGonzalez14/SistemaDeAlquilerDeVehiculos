using SegundoParcial.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public List<Alquiler> getAllHistory()
        {
            return alquilerRepository.GetAllBy(x=> x.Estatus =="I");
        }
        public Alquiler findById(int id)
        {
            return alquilerRepository.FindById(id);
        }

        public OperationResult Create(Alquiler alquiler)
        {
            var existsAlquiler = alquilerRepository.Find(x => x.VehiculoId == alquiler.VehiculoId  && x.Estatus.Equals("A") && x.Borrado == false);

            if (existsAlquiler != null)
            {
                return new OperationResult() { Data = null, Message = "Error alquiler existente", Success = false };
            }

            var createdAlquiler = alquilerRepository.Create(alquiler);
            return new OperationResult() { Data = createdAlquiler, Message = "Alquiler creado satisfactoriamente", Success = true };
        }

        public OperationResult Edit(Alquiler alquiler)
        {
            var existsAlquiler = alquilerRepository.Find(x => x.VehiculoId == alquiler.VehiculoId && x.Estatus.Equals("A") && x.Borrado == false);
            if (existsAlquiler != null && existsAlquiler.Id != alquiler.Id)
            {
                return new OperationResult() { Data = null, Message = "Error existe un alquiler con dicho vehiculo", Success = false };
            }

            var currentAlquiler = alquilerRepository.FindById(alquiler.Id);
            currentAlquiler.FechaDevolucion = alquiler.FechaDevolucion;
            currentAlquiler.Penalidad = alquiler.Penalidad;
            currentAlquiler.Estatus = alquiler.Estatus;
            currentAlquiler.FechaModificacion = alquiler.FechaModificacion;

            return alquilerRepository.Update(currentAlquiler);

            
        }

        public OperationResult EndAlquiler(Alquiler alquiler)
        {
            var existsAlquiler = alquilerRepository.Find(x => x.Id == alquiler.Id  && x.Borrado == false);
            if (existsAlquiler != null )
            {
                existsAlquiler.Estatus = alquiler.Estatus;
                if (alquiler.Penalidad != 0) {
                    existsAlquiler.Penalidad = alquiler.Penalidad;
                }
                
                existsAlquiler.FechaModificacion = DateTime.Now;

                return alquilerRepository.Update(existsAlquiler);
            }
            return new OperationResult() { Data = null, Message = "Error existe un alquiler con dicho vehiculo", Success = false };
        }

        public OperationResult Delete(Alquiler alquiler)
        {
            return alquilerRepository.Delete(alquiler.Id);
        }
    }
}

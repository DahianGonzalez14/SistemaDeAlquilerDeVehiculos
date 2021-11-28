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

        public Alquiler findById(int id)
        {
            return alquilerRepository.FindById(id);
        }

        public OperationResult Create(Alquiler alquiler)
        {
            var existsAlquiler = alquilerRepository.Find(x => x.ClienteId == alquiler.ClienteId && x.VehiculoId == alquiler.VehiculoId && x.FechaDesde.ToString("dd/MMM/yyyy").Equals(alquiler.FechaDesde.ToString("dd/MMM/yyyy")) && x.FechaHasta.ToString("dd/MMM/yyyy").Equals(alquiler.FechaHasta.ToString("dd/MMM/yyyy")) && x.Borrado == false);

            if (existsAlquiler != null)
            {
                return new OperationResult() { Data = null, Message = "Error alquiler existente", Success = false };
            }

            var createdAlquiler = alquilerRepository.Create(alquiler);
            return new OperationResult() { Data = createdAlquiler, Message = "Alquiler creado satisfactoriamente", Success = true };
        }

        public OperationResult Edit(Alquiler alquiler)
        {
            var existsAlquiler = alquilerRepository.Find(x => x.ClienteId == alquiler.ClienteId && x.VehiculoId == alquiler.VehiculoId && x.FechaDesde.ToString("dd/MMM/yyyy").Equals(alquiler.FechaDesde.ToString("dd/MMM/yyyy")) && x.FechaHasta.ToString("dd/MMM/yyyy").Equals(alquiler.FechaHasta.ToString("dd/MMM/yyyy")) && x.Borrado == false);
            if (existsAlquiler != null && existsAlquiler.Id == alquiler.Id)
            {
                existsAlquiler.ClienteId = alquiler.ClienteId;
                existsAlquiler.VehiculoId = alquiler.VehiculoId;
                existsAlquiler.MetodoPago = alquiler.MetodoPago;
                existsAlquiler.Costo = alquiler.Costo;
                existsAlquiler.FechaDesde = alquiler.FechaDesde;
                existsAlquiler.FechaHasta  = alquiler.FechaHasta;
                existsAlquiler.FechaDevolucion = alquiler.FechaDevolucion;
                existsAlquiler.Penalidad = alquiler.Penalidad;
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

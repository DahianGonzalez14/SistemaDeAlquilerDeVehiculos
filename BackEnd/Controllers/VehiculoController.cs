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
    public class VehiculoController
    {
        VehiculoRepository vehiculoRepository;
        public VehiculoController()
        {
            vehiculoRepository = new VehiculoRepository();
        }

        public List<Vehiculo> getAll()
        {
            return vehiculoRepository.GetAll();
        }

        public Vehiculo findById(int id)
        {
            return vehiculoRepository.FindById(id);
        }

        public OperationResult Create(Vehiculo vehiculo)
        {
            var existsVehiculo = vehiculoRepository.Find(x => x.Chasis.Equals(vehiculo.Chasis) || x.Placa.Equals(vehiculo.Placa));

            if (existsVehiculo == null)
            {
                return new OperationResult() { Data = null, Message = "Error vehiculo existente", Success = false };
            }

            var createdVehiculo = vehiculoRepository.Create(vehiculo);
            return new OperationResult() { Data = createdVehiculo, Message = "Vehiculo creado satisfactoriamente", Success = true };
        }

        public OperationResult Edit(Vehiculo vehiculo)
        {
            var existsVehiculo = vehiculoRepository.Find(x => x.Chasis.Equals(vehiculo.Chasis) || x.Placa.Equals(vehiculo.Placa));
            if (existsVehiculo != null || existsVehiculo.Id == vehiculo.Id)
            {
                return vehiculoRepository.Update(vehiculo);
            }
            return new OperationResult() { Data = null, Message = "Error existe un vehiculo con dicha placa o chasís", Success = false };
        }

        public OperationResult Delete(Vehiculo vehiculo)
        {
            return vehiculoRepository.Delete(vehiculo.Id);
        }
    }
}

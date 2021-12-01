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
            var existsVehiculo = vehiculoRepository.Find(x => x.Chasis.Equals(vehiculo.Chasis) || x.Placa.Equals(vehiculo.Placa) && x.Borrado == false);
            if (existsVehiculo != null)
            {
                return new OperationResult() { Data = null, Message = "Error vehiculo existente", Success = false };
            }

            var createdVehiculo = vehiculoRepository.Create(vehiculo);
            return new OperationResult() { Data = createdVehiculo, Message = "Vehiculo creado satisfactoriamente", Success = true };
        }

        public OperationResult Edit(Vehiculo vehiculo)
        {
            var existsVehiculo = vehiculoRepository.Find(x => (x.Chasis.Equals(vehiculo.Chasis) || x.Placa.Equals(vehiculo.Placa)) && x.Borrado == false);
            if (existsVehiculo != null && existsVehiculo.Id != vehiculo.Id)
            {
                return new OperationResult() { Data = null, Message = "Error existe un vehiculo con dicha placa o chasís", Success = false };
            }

            var currentVehiculo = vehiculoRepository.FindById(vehiculo.Id);
            currentVehiculo.TipoTransmisionId = vehiculo.TipoTransmisionId;
            currentVehiculo.TipoCombustibleId = vehiculo.TipoCombustibleId;
            currentVehiculo.ModeloId = vehiculo.ModeloId;
            currentVehiculo.Chasis = vehiculo.Chasis;
            currentVehiculo.Placa = vehiculo.Placa;
            currentVehiculo.Anio = vehiculo.Anio;
            currentVehiculo.Color = vehiculo.Color;
            currentVehiculo.Cilindraje = vehiculo.Cilindraje;
            currentVehiculo.KilometrosTablero = vehiculo.KilometrosTablero;
            currentVehiculo.CantidadPuerta = vehiculo.CantidadPuerta;
            currentVehiculo.Precio = vehiculo.Precio;
            currentVehiculo.Estatus = vehiculo.Estatus;
            currentVehiculo.FechaModificacion = DateTime.Now;

            return vehiculoRepository.Update(currentVehiculo);
        }

        public OperationResult Delete(Vehiculo vehiculo)
        {
            return vehiculoRepository.Delete(vehiculo.Id);
        }
    }
}

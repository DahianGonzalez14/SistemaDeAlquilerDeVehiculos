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
            var existsVehiculo = vehiculoRepository.Find(x => x.Chasis.Equals(vehiculo.Chasis) || x.Placa.Equals(vehiculo.Placa) && x.Borrado == false);
            if (existsVehiculo != null && existsVehiculo.Id == vehiculo.Id)
            {
                existsVehiculo.TipoTransmisionId = vehiculo.TipoTransmisionId;
                existsVehiculo.TipoCombustibleId = vehiculo.TipoCombustibleId;
                existsVehiculo.ModeloId = vehiculo.ModeloId;
                existsVehiculo.Chasis = vehiculo.Chasis;
                existsVehiculo.Placa = vehiculo.Placa;
                existsVehiculo.Anio = vehiculo.Anio;
                existsVehiculo.Color = vehiculo.Color;
                existsVehiculo.Cilindraje = vehiculo.Cilindraje;
                existsVehiculo.KilometrosTablero = vehiculo.KilometrosTablero;
                existsVehiculo.CantidadPuerta = vehiculo.CantidadPuerta;
                existsVehiculo.Precio = vehiculo.Precio;
                existsVehiculo.FechaModificacion = DateTime.Now;

                return vehiculoRepository.Update(existsVehiculo);
            }
            return new OperationResult() { Data = null, Message = "Error existe un vehiculo con dicha placa o chasís", Success = false };
        }

        public OperationResult Delete(Vehiculo vehiculo)
        {
            return vehiculoRepository.Delete(vehiculo.Id);
        }
    }
}

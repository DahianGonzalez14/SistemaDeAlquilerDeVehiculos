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
    public class ClienteController
    {
        ClienteRepository clienteRepository;
        public ClienteController()
        {
            clienteRepository = new ClienteRepository();
        }

        public List<Cliente> getAll()
        {
            return clienteRepository.GetAll();
        }

        public Cliente findById(int id)
        {
            return clienteRepository.FindById(id);
        }

        public OperationResult Create(Cliente cliente)
        {
            var existsCliente = clienteRepository.Find(x => x.Cedula.Equals(cliente.Cedula) && x.Borrado == false);

            if (existsCliente != null)
            {
                return new OperationResult() { Data = null, Message = "Error cliente existente", Success = false };
            }

            var createdCliente = clienteRepository.Create(cliente);
            return new OperationResult() { Data = createdCliente, Message = "Cliente creado satisfactoriamente", Success = true };
        }

        public OperationResult Edit(Cliente cliente)
        {
            var existsCliente = clienteRepository.Find(x => x.Cedula.Equals(cliente.Cedula) && x.Borrado == false);
            if (existsCliente != null && existsCliente.Id == cliente.Id)
            {
                existsCliente.Nombre = cliente.Nombre;
                existsCliente.Apellido = cliente.Apellido;
                existsCliente.Direccion = cliente.Direccion;
                existsCliente.Telefono = cliente.Telefono;
                existsCliente.Correo = cliente.Correo;
                existsCliente.Cedula = cliente.Cedula;
                existsCliente.FechaModificacion = DateTime.Now;

                return clienteRepository.Update(existsCliente);
            }
            return new OperationResult() { Data = null, Message = "Error existe un cliente con dicha cédula", Success = false };
        }

        public OperationResult Delete(Cliente cliente)
        {
            return clienteRepository.Delete(cliente.Id);
        }
    }
}

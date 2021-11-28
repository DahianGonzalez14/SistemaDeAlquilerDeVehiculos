using SegundoParcial.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public Cliente findByCedula(string cedula)
        {
            return clienteRepository.Find(x => x.Cedula == cedula && x.Borrado == false);
        }

        public OperationResult Create(Cliente cliente)
        {
            var existsClienteWithSameCedula = clienteRepository.Find(x => x.Cedula.Equals(cliente.Cedula) && x.Borrado == false);
            var existsClienteWithSameTelefono = clienteRepository.Find(x => x.Telefono.Equals(cliente.Telefono) && x.Borrado == false);
            var existsClienteWithSameCorreo = clienteRepository.Find(x => x.Correo.Equals(cliente.Correo) && x.Borrado == false);

            if (existsClienteWithSameTelefono != null)
            {
                return new OperationResult() { Data = null, Message = "Error cliente existente con el mismo teléfono", Success = false };
            }

            if (existsClienteWithSameCorreo != null)
            {
                return new OperationResult() { Data = null, Message = "Error cliente existente con el mismo correo", Success = false };
            }

            if (existsClienteWithSameCedula != null)
            {
                return new OperationResult() { Data = null, Message = "Error cliente existente con la misma cédula", Success = false };
            }

            var createdCliente = clienteRepository.Create(cliente);
            return new OperationResult() { Data = createdCliente, Message = "Cliente creado satisfactoriamente", Success = true };
        }

        public OperationResult Edit(Cliente cliente)
        {
            var existsClienteWithSameCedula = clienteRepository.Find(x => x.Cedula.Equals(cliente.Cedula) && x.Borrado == false);
            var existsClienteWithSameTelefono = clienteRepository.Find(x => x.Telefono.Equals(cliente.Telefono) && x.Borrado == false);
            var existsClienteWithSameCorreo = clienteRepository.Find(x => x.Correo.Equals(cliente.Correo) && x.Borrado == false);

            if (existsClienteWithSameTelefono != null && existsClienteWithSameTelefono.Id != cliente.Id)
            {
                return new OperationResult() { Data = null, Message = "Error cliente existente con el mismo teléfono", Success = false };
            }

            if (existsClienteWithSameCorreo != null && existsClienteWithSameCorreo.Id != cliente.Id)
            {
                return new OperationResult() { Data = null, Message = "Error cliente existente con el mismo correo", Success = false };
            }

            if (existsClienteWithSameCedula != null && existsClienteWithSameCedula.Id != cliente.Id)
            {
                return new OperationResult() { Data = null, Message = "Error cliente existente con la misma cédula", Success = false };
            }

            var currentClient = clienteRepository.FindById(cliente.Id);

            currentClient.Nombre = cliente.Nombre;
            currentClient.Apellido = cliente.Apellido;
            currentClient.Direccion = cliente.Direccion;
            currentClient.Telefono = cliente.Telefono;
            currentClient.Correo = cliente.Correo;
            currentClient.Cedula = cliente.Cedula;
            currentClient.Estatus = cliente.Estatus;
            currentClient.FechaModificacion = DateTime.Now;

            return clienteRepository.Update(currentClient);
        }

        public OperationResult Delete(Cliente cliente)
        {
            return clienteRepository.Delete(cliente.Id);
        }

        public bool isValidCedula(string cedula)
        {
            string strRegex = @"^[0-9]{3}-?[0-9]{7}-?[0-9]{1}$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(cedula))
                return (true);
            else
                return (false);
        }

        public bool isValidTelefono(string telefono)
        {
            string strRegex = @"(8(?:0|2|4)9)-?[0-9]{3}-?([0-9]{4})";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(telefono))
                return (true);
            else
                return (false);
        }

        public bool isValidCorreo(string correo)
        {
            string strRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(correo))
                return (true);
            else
                return (false);
        }
    }
}

using SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Implementations;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoParcial.Helpers;
namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities
{
    public class TipoCombustibleController
    {
        TipoCombustibleRepository tipoCombustibleRepository;

        public TipoCombustibleController()
        {
            tipoCombustibleRepository = new TipoCombustibleRepository();
        }

        public List<TipoCombustible> getAll()
        {
            return tipoCombustibleRepository.GetAll();
        }

        public TipoCombustible findById(int id)
        {
            return tipoCombustibleRepository.FindById(id);
        }

        public OperationResult Create(TipoCombustible tipoCombustible)
        {
            Console.WriteLine(tipoCombustible);
            var existTipoCombustible= tipoCombustibleRepository.Find(x => x.Nombre.Equals(tipoCombustible.Nombre));
            
            if (existTipoCombustible == null)
            {
                var createdTipoCombustible = tipoCombustibleRepository.Create(tipoCombustible);

                return new OperationResult() { Data = createdTipoCombustible, Message = "Modelo creado satisfatoria mente", Success = true };
       

            }
            return new OperationResult() { Data = null, Message = "Error  existente", Success = false };
            //var createdTipoCombustible = tipoCombustibleRepository.Create(tipoCombustible);

          //  return new OperationResult() { Data = createdTipoCombustible, Message = "Modelo creado satisfatoria mente", Success = true };
        }

        public OperationResult Edit(TipoCombustible tipoCombustible)
        {
            var existTipoCombustible = tipoCombustibleRepository.Find(x => x.Id.Equals(tipoCombustible.Id));
            if (existTipoCombustible != null)
            {
                existTipoCombustible.Nombre = tipoCombustible.Nombre;
                existTipoCombustible.FechaModificacion = tipoCombustible.FechaModificacion;
                return tipoCombustibleRepository.Update(existTipoCombustible);
            }
            return new OperationResult() { Data = null, Message = "Error existe una transmicion con dicho nombre", Success = false };
        }

        public OperationResult Delete(TipoCombustible tipoCombustible)
        {
            return tipoCombustibleRepository.Delete(tipoCombustible.Id);
        }




    }
}

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
            var existsTipoCombustible= tipoCombustibleRepository.Find(x => x.Nombre.Equals(tipoCombustible.Nombre) && x.Borrado == false);
            if (existsTipoCombustible != null)
            {
                return new OperationResult() { Data = null, Message = "Error Tipo de combustible existente", Success = false };
            }

            var createdTipoCombustible = tipoCombustibleRepository.Create(tipoCombustible);
            return new OperationResult() { Data = createdTipoCombustible, Message = "Tipo de combustible creado satisfatoriamente", Success = true };
        }

        public OperationResult Edit(TipoCombustible tipoCombustible)
        {
            var existsTipoCombustible = tipoCombustibleRepository.Find(x => x.Id.Equals(tipoCombustible.Id) && x.Borrado == false);
            if (existsTipoCombustible != null && existsTipoCombustible.Id == tipoCombustible.Id)
            {
                existsTipoCombustible.Nombre = tipoCombustible.Nombre;
                existsTipoCombustible.FechaModificacion = tipoCombustible.FechaModificacion;

                return tipoCombustibleRepository.Update(existsTipoCombustible);
            }

            return new OperationResult() { Data = null, Message = "Error existe un tipo de combustible con dicho nombre", Success = false };
        }

        public OperationResult Delete(TipoCombustible tipoCombustible)
        {
            return tipoCombustibleRepository.Delete(tipoCombustible.Id);
        }




    }
}

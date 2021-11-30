using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoParcial.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Implementations;
namespace SistemaDeAlquilerDeVehiculos.BackEnd.Controllers
{
   public class TipoTransmisionController
    {
        TipoTransmisionRepository tipoTransmisionRepository;

        public TipoTransmisionController()
        {
            tipoTransmisionRepository = new TipoTransmisionRepository();
        }

        public List<TipoTransmision> getAll()
        {
            return tipoTransmisionRepository.GetAll();
        }

        public TipoTransmision findById(int id)
        {
            return tipoTransmisionRepository.FindById(id);
        }

        public OperationResult Create(TipoTransmision tipoTransmision)
        {
            var existsTipoTrasnsmision = tipoTransmisionRepository.Find(x => x.Nombre.Equals(tipoTransmision.Nombre) && x.Borrado == false);
            if (existsTipoTrasnsmision != null)
            {
                return new OperationResult() { Data = null, Message = "Error tipo de transmisión existente", Success = false };

            }
            var createdTipoTransmision = tipoTransmisionRepository.Create(tipoTransmision);
            return new OperationResult() { Data = createdTipoTransmision, Message = "Tipo de transmisión creado satisfatoriamente", Success = true };
        }
        public OperationResult Edit(TipoTransmision tipoTransmision)
        {
            var existsTipoTransmision = tipoTransmisionRepository.Find(x => x.Nombre.Equals(tipoTransmision.Nombre) && x.Borrado == false);
            if (existsTipoTransmision != null && existsTipoTransmision.Id != tipoTransmision.Id)
            {
                return new OperationResult() { Data = null, Message = "Error existe un tipo de transmisión con dicho nombre", Success = false };
            }

            var currentTipoTransmision = tipoTransmisionRepository.FindById(tipoTransmision.Id);
            currentTipoTransmision.Nombre = tipoTransmision.Nombre;
            currentTipoTransmision.Estatus = tipoTransmision.Estatus;
            currentTipoTransmision.FechaModificacion = DateTime.Now;

            return tipoTransmisionRepository.Update(currentTipoTransmision);
                     
        }

        public OperationResult Delete(TipoTransmision tipoTransmision)
        {
            return tipoTransmisionRepository.Delete(tipoTransmision.Id);
        }

    }
}

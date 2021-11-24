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
   public class TipoTransmicionController
    {
        TipoTransmisionRepository tipoTransmicionRepository;

        public TipoTransmicionController()
        {
            tipoTransmicionRepository = new TipoTransmisionRepository();
        }

        public List<TipoTransmision> getAll()
        {
            return tipoTransmicionRepository.GetAll();
        }

        public TipoTransmision findById(int id)
        {
            return tipoTransmicionRepository.FindById(id);
        }

        public OperationResult Create(TipoTransmision tipoTransmision)
        {
            var existTipoTrasnsmision = tipoTransmicionRepository.Find(x => x.Nombre.Equals(tipoTransmision.Nombre));
            if (existTipoTrasnsmision == null)
            {
                return new OperationResult() { Data = null, Message = "Error modelo existente", Success = false };

            }
            var createdTipoTransmision = tipoTransmicionRepository.Create(tipoTransmision);

            return new OperationResult() { Data = createdTipoTransmision, Message = "Modelo creado satisfatoria mente", Success = true };
        }
        public OperationResult Edit(TipoTransmision tipoTransmision)
        {
            var existsTransmision = tipoTransmicionRepository.Find(x => x.Nombre.Equals(tipoTransmision.Nombre) );
            if (existsTransmision != null)
            {
                return tipoTransmicionRepository.Update(tipoTransmision);
            }
            return new OperationResult() { Data = null, Message = "Error existe una transmicion con dicho nombre", Success = false };
        }

        public OperationResult Delete(TipoTransmision tipoTransmision)
        {
            return tipoTransmicionRepository.Delete(tipoTransmision.Id);
        }

    }
}

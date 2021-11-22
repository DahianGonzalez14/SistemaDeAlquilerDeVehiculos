using SegundoParcial.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Context;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private Context context;
        private DbSet<T> set;

        public Repository()
        {
            context = new Context();
            set = context.Set<T>();
        }
        public T Create(T entity)
        {
            set.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public OperationResult Delete(int id)
        {
            var entity = FindById(id);

            if(entity == null)
            {
                return new OperationResult() { Data = null, Message = "No existe", Success = false };
            }

            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            entity.Borrado = true;
            entity.FechaModificacion = DateTime.Now;
            context.SaveChanges();
            return new OperationResult() { Success = true, Data = entity, Message = "Borrado satisfactoriamente"};
        }

        public T FindById(int id)
        {
            return set.FirstOrDefault(x => x.Id == id);
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            return set.FirstOrDefault(predicate);
        }

        public List<T> GetAll()
        {
            return set.Where(x => x.Borrado == false).ToList();
        }

        public List<T> GetAllBy(Expression<Func<T, bool>> predicate)
        {
            return set.Where(predicate).ToList();
        }

        public OperationResult Update(T entity)
        {
            var currentEntity = FindById(entity.Id);

            if (currentEntity == null)
            {
                return new OperationResult() { Data = null, Message = "No existe", Success = false };
            }

            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return new OperationResult() { Success = true, Data = entity, Message = "Actualizado satisfactoriamente" };
        }
    }
}

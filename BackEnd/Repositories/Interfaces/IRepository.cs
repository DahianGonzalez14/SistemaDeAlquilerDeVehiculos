using SegundoParcial.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        T Create(T entity);
        List<T> GetAll();
        List<T> GetAllBy(Expression<Func<T, bool>> predicate);
        T FindById(int id);
        T Find(Expression<Func<T, bool>> predicate);
        OperationResult Update(T entity);
        OperationResult Delete(int id);
    }
}

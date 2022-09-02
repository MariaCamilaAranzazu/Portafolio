using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.AppRepositorios
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<T> Insert(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> GetBy(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Delete(T entity);
    }
}
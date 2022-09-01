using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.AppRepositorios
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int Id);
        Task<T> GetByCedula(int Cedula);
        Task<T> GetByPlaca(string Placa);

        Task<T> Insert(T entity);

        Task<T> DeleteByID(int Id);
        Task<T> DeleteByCedula(int Id);
        Task<T> DeleteByPlaca(string Id);
        
        Task Update(T entity);
    }
}
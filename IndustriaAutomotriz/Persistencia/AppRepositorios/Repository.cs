using System.Globalization;
using System.Threading;
using System.Dynamic;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistencia.AppRepositorios;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDBContext _context;

        public Repository(AppDBContext context)
        {
            this._context = context;
        }

        protected DbSet<T> EntitySet
        {
            get
            {
                return _context.Set<T>();
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await EntitySet.ToListAsync();
        }
         
        public async Task<T> GetByID(int Id)
        {
            return await EntitySet.FindAsync(Id);
        }

        public async Task<T> GetByCedula(int Cedula)
        {
            return await EntitySet.FindAsync(Cedula);
        }

        public async Task<T> GetByPlaca(string Placa)
        {
            return await EntitySet.FindAsync(Placa);
        }

        public async Task<T> Insert(T entity)
        {
            EntitySet.Add(entity);
            await Save();
            return entity;
        }

        public async Task<T> DeleteByID(int Id)
        {
            T entity = await EntitySet.FindAsync(Id);
            EntitySet.Remove(entity);
            await Save();
            return entity;
        }

        public async Task<T> DeleteByCedula(int Cedula)
        {
            T entity = await EntitySet.FindAsync(Cedula);
            EntitySet.Remove(entity);
            await Save();
            return entity;
        }

        public async Task<T> DeleteByPlaca(string Placa)
        {
            T entity = await EntitySet.FindAsync(Placa);
            EntitySet.Remove(entity);
            await Save();
            return entity;
        }

        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await Save();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
        public AppDBContext _context;
        public DbSet<T> table;

        public Repository()
        {
            this._context = new AppDBContext();
            table = _context.Set<T>();
        }

        /*public Repository(AppDBContext context)
        {
            this._context = context;
            table = this._context.Set<T>();
        }*/

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }
         
        public async Task<T> GetByID(int Id)
        {
            return await table.FindAsync(Id);
        }

        public async Task<T> GetByCedula(int Cedula)
        {
            return await table.FindAsync(Cedula);
        }

        public async Task<T> GetByPlaca(string Placa)
        {
            return await table.FindAsync(Placa);
        }

        public async Task<T> Insert(T entity)
        {
            Console.WriteLine("Esto se ejecuta?");
            await table.AddAsync(entity);
            Console.WriteLine("Parece que si... :D");
            //_context.SaveChanges();
            //Console.WriteLine("Parece que si... :D");
            _context.SaveChanges();

            Console.WriteLine("Se guardó correctamente!");
            return entity;
        }

        public async Task<T> DeleteByID(int Id)
        {
            T entity = await table.FindAsync(Id);
            table.Remove(entity);
            await Save();
            return entity;
        }

        public async Task<T> DeleteByCedula(int Cedula)
        {
            T entity = await table.FindAsync(Cedula);
            table.Remove(entity);
            await Save();
            return entity;
        }

        public async Task<T> DeleteByPlaca(string Placa)
        {
            T entity = await table.FindAsync(Placa);
            table.Remove(entity);
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
            Console.WriteLine("Entra en el método guardar, pero parece que no sale, o si?");
            await _context.SaveChangesAsync();
            Console.WriteLine("Ya saliooooo!");
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
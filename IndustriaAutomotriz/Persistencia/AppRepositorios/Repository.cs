using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Threading;
using System.Dynamic;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistencia.AppRepositorios;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class Repository<T> : IRepository<T> where T : class//, IEntity
    {
        public AppDBContext _context;
        public DbSet<T> table;

        public Repository()
        {
            var contextOptions = new DbContextOptionsBuilder<AppDBContext>()
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database = IndustriaAutomotrizData")
            .Options;
            this._context = new AppDBContext(contextOptions);
            table = _context.Set<T>();
        }

        public Repository(AppDBContext context)
        {
            this._context = context;
            table = this._context.Set<T>();
        }

        public async Task<T> Insert(T entity)
        {
            Console.WriteLine("Guardando");
            await table.AddAsync(entity);
            Console.WriteLine("Parece que... :D");
            Save();

            Console.WriteLine("Se guardó correctamente!");
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }
         
        public async Task<T> GetById(int id)
        {
            return await table.FindAsync(id);
            //return table.Find(id);
        }

        public async Task<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return await table.FirstOrDefaultAsync(predicate);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            table.Remove(entity);
            Save();
        }

        public void Save()
        {
            Console.WriteLine("Entra en el método guardar, pero parece que no sale, o si?");
            _context.SaveChanges();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }
        public AppDBContext(DbContextOptions<AppDBContext> options)
          : base(options)
        {
        }

        public DbSet<AccesoCliente> AccesosClientes {get;set;}
        public DbSet<AccesoEmpleado> AccesosEmpleados {get;set;}
        public DbSet<Cargo> Cargos {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Empleado> Empleados {get;set;}
        public DbSet<OrdenServicio> OrdenesServicios {get;set;}
        public DbSet<Repuesto> Repuestos {get;set;}
        public DbSet<RepuestoxServicio> RepuestosxServicios {get;set;}
        public DbSet<Revision> Revisiones {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = IndustriaAutomotrizData");
        }
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=IndustriaAutomotrizData");
    }
    }

}
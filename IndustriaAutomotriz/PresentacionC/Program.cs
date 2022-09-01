using System.Runtime.CompilerServices;
using System.Net;
using System.Security.AccessControl;
using System;
using Dominio;
using Dominio.Entidades;
using Persistencia;
using Persistencia.AppRepositorios;
using Microsoft.EntityFrameworkCore;

namespace PresentacionC
{
    class Program
    {
        /*public static AppDBContext DBContext = new AppDBContext();
        //public static Repository<AccesoCliente> repository = new repositorio

        public static Repository<AccesoCliente> _repository = new Repository<AccesoCliente>(DBContext);*/

        static void Main(string[] args)
        {
           agregarAccesoC();
        }

        private static void agregarAccesoC()
        {
            AppDBContext DBContext = new AppDBContext();
            AccesoCliente accesoC = new AccesoCliente();
            IRepository<AccesoCliente> _repository = new Repository<AccesoCliente>(DBContext);

            accesoC.Id = 1;
            accesoC.ClienteCedula = 1024530890;
            accesoC.usuario = "ed";
            accesoC.contraseña = "ed123";
            accesoC.fecha_creacion = "31/08/2022";
            
            _repository.Insert(accesoC);

            Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.ClienteCedula);
            Console.WriteLine("Se agregó: " + accesoC.usuario);
            Console.WriteLine("Se agregó: " + accesoC.contraseña);
            Console.WriteLine("Se agregó: " + accesoC.fecha_creacion);
        }

    }
}

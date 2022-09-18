using System.Runtime.CompilerServices;
using System.Net;
using System.Security.AccessControl;
using System;
using Dominio;
using Dominio.Entidades;
using Persistencia;
using Persistencia.AppRepositorios;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

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
            var contextOptions = new DbContextOptionsBuilder<AppDBContext>()
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database = IndustriaAutomotrizData")
            .Options;
            var DBContext = new AppDBContext(contextOptions);
            var repositorioAccesoC = new Repository<Cliente>(DBContext); //A la instacia Repository<> se le pasa el nombre de la entidad cuya tabla queremos modificar.
            var accesoC = new Cliente(); //Se crea una nueva instacia con el nombre de la entidad que ajustamos en la linea anterior.

            //Descomentar el código de acuerdo a la entidad que queramos crear para pasarle un nuevo registro a la tabla.
            //Corregir el nombre de las variables porque se hicieron con la migración anterior.


            //Datos Acceso Cliente

            /*accesoC.Id = 2;
            accesoC.ClienteCedula = 12345678;
            accesoC.Usuario = "Cristian";
            accesoC.Contraseña = "654321";
            accesoC.FechaCreacion = "2/09/2022";*/

            //Datos Acceso Empleado
            /*accesoC.EmpleadoCedula = ;
            accesoC.contraseña = "Asincrono";
            accesoC.fecha_creacion = "1/09/2022";*/


            //Datos Cargo
            //accesoC.nombre = "Jefe";

            //Datos Orden Servicio
            /*accesoC.rev_id = 2022001;
            accesoC.emp_cedula = 1234567;
            accesoC.act_software = "No";
            accesoC.inst_repuestos = "Si";
            accesoC.costo_respuestos = 50000;
            accesoC.costo_servicio = 150000; 
            accesoC.total_pagar = 200000;
            accesoC.fecha_creacion = "1/09/2022";
            accesoC.observaciones = "El carro tenia muchos daños y ya no sirve para un carajo.";*/

            //Datos Repuesto
            /*accesoC.nombre = "Llanta";
            accesoC.cantidad = 10;
            accesoC.precio_unidad = 80000;
            accesoC.fecha_creacion = "1/09/2022";*/

            //Datos RepuestoxServicio
            /*accesoC.OrdenServicioId = 1;
            accesoC.RepuestoId = 1;
            accesoC.cant_actual = 10;
            accesoC.cant_sal_ent = 2;
            accesoC.valor_pagar = 160000;
            accesoC.fecha_creacion = "1/09/2022";*/

            //Datos Revision
            /*accesoC.ClienteCedula = 59832154;
            accesoC.EmpleadoCedula = 12345678;
            accesoC.VehiculoPlaca = "ABC 123";
            accesoC.est_aceite = "Cambio";
            accesoC.est_filtro_aire = "Cambio";
            accesoC.est_filtro_gasolina = "Bueno";
            accesoC.tipo_mantenimiento = "Correctivo";
            accesoC.fecha_creacion = "01/9/2022";
            accesoC.observaciones = "Cambiar aceite";*/

            //Cliente
            accesoC.Nombre = "Edward";
            accesoC.Apellido = "Bonilla";
            accesoC.Cedula = 56123789;
            accesoC.Telefono = 3177150099;
            accesoC.Direccion = "La patagonia";
            accesoC.Correo = "paraqueoque@paraque.com";
            accesoC.FechaCreacion = DateTime.Now;

            //Empleado
            /*accesoC.Nombre = "Edward";
            accesoC.Apellido = "Bonilla";
            accesoC.Cedula = 56123789;
            accesoC.CargoId = 1;
            accesoC.Telefono = 317715009;
            accesoC.Direccion = "La patagonia";
            accesoC.Correo = "paraqueoque@paraque.com";
            accesoC.FechaCreacion = "1//9/2022";*/

            //Vehiculo
            /*accesoC.Tipo = "Camioneta";
            accesoC.Placa = "ABC 123";
            accesoC.CliCedula = 56123789;
            accesoC.Marca = "Nissan";
            accesoC.Modelo = "Quien sabe";
            accesoC.Color = "Verde Fosforescente";
            accesoC.FechaCreacion = "1//9/2022";*/


            Console.WriteLine("Datos asignados a la entidad, correctamente...");

            //Encontrar por ID
            //var accesoEncontrado = repositorioAccesoC.GetById(7).Result;
            //Linea para saber que se encontró
            //Console.WriteLine("Se encontró: " + accesoEncontrado.Usuario);

            //Encontrar por cualquier otro criterio
            //var accesoEncontrado = repositorioAccesoC.GetBy(c => c.Cedula == 12345678).Result;
            //Linea para saber que se encontró
            /*Console.WriteLine("Se encontró: " + accesoEncontrado.Nombre);
            Console.WriteLine("Se encontró: " + accesoEncontrado.Apellido);
            Console.WriteLine("Se encontró: " + accesoEncontrado.Cedula);
            Console.WriteLine("Se encontró: " + accesoEncontrado.Telefono);
            Console.WriteLine("Se encontró: " + accesoEncontrado.Direccion);
            Console.WriteLine("Se encontró: " + accesoEncontrado.Correo);*/

            //Obtener todos los valores en una lista
            //var accesoEncontrado = repositorioAccesoC.GetAll().Result;
            /*foreach (AccesoCliente registro in accesoEncontrado)
            {
                Console.WriteLine("Se encontró Id: " + registro.Id);
                Console.WriteLine("Se encontró Cedula: " + registro.ClienteCedula);
                Console.WriteLine("Se encontró Usuario: " + registro.Usuario);
                Console.WriteLine("Se encontró Contraseña: " + registro.Contraseña);
                Console.WriteLine("Se encontró Fecha de registro: " + registro.FechaCreacion );
                Console.WriteLine("*************************************************************" );

            }*/

            //Editar registro Encontrado

            /*var accesoEncontrado = repositorioAccesoC.GetBy(a => a.Usuario == "Edward").Result;
            //Linea para saber que se encontró
            Console.WriteLine("Se encontró: " + accesoEncontrado.Usuario);

            accesoEncontrado.ClienteCedula = 51422698;
            accesoEncontrado.Usuario = "Jacinto";
            accesoEncontrado.Contraseña = "Jac789";
            accesoEncontrado.FechaCreacion = "3/09/2022";

            repositorioAccesoC.Update(accesoEncontrado);*/

            //Eliminar Registro: Se busca primero y se guarda en una variable y se le pasa a la función Delete.
            /*var accesoEncontrado = repositorioAccesoC.GetById(8).Result;
            repositorioAccesoC.Delete(accesoEncontrado);
            Console.WriteLine("Se eliminó: " + accesoEncontrado.Usuario);*/


            //Linea para saber que se encontró
            //Console.WriteLine("Se encontró: " + accesoEncontrado.Usuario);
            

            //Descomentar el bloque correspondiente a la entidad que vamos a agregar, para verificar por consola los datos agregados
            //Tambien hay que corregir nombres de variables.

            //INSERTAR REGISTRO 


            repositorioAccesoC.Insert(accesoC);

            //acceso Cliente
            /*Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.ClienteCedula);
            Console.WriteLine("Se agregó: " + accesoC.Usuario);
            Console.WriteLine("Se agregó: " + accesoC.Contraseña);
            Console.WriteLine("Se agregó: " + accesoC.FechaCreacion);*/

            //Acceso Empleado
            /*Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.EmpleadoCedula);
            Console.WriteLine("Se agregó: " + accesoC.contraseña);
            Console.WriteLine("Se agregó: " + accesoC.fecha_creacion);*/

            //Cargo
            /*Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.nombre);
            Console.WriteLine("Se agregó: " + accesoC.fecha_creacion);*/

            //Orden Servicio
            /*Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.rev_id);
            Console.WriteLine("Se agregó: " + accesoC.emp_cedula);
            Console.WriteLine("Se agregó: " + accesoC.act_software);
            Console.WriteLine("Se agregó: " + accesoC.inst_repuestos);
            Console.WriteLine("Se agregó: " + accesoC.costo_respuestos);
            Console.WriteLine("Se agregó: " + accesoC.costo_servicio);
            Console.WriteLine("Se agregó: " + accesoC.total_pagar);
            Console.WriteLine("Se agregó: " + accesoC.fecha_creacion);
            Console.WriteLine("Se agregó: " + accesoC.observaciones);*/

            //Repuesto
            /*Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.nombre);
            Console.WriteLine("Se agregó: " + accesoC.cantidad);
            Console.WriteLine("Se agregó: " + accesoC.precio_unidad);
            Console.WriteLine("Se agregó: " + accesoC.fecha_creacion);*/

            //RepuestoxServicio
            /*Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.OrdenServicioId);
            Console.WriteLine("Se agregó: " + accesoC.RepuestoId);
            Console.WriteLine("Se agregó: " + accesoC.cant_actual);
            Console.WriteLine("Se agregó: " + accesoC.cant_sal_ent);
            Console.WriteLine("Se agregó: " + accesoC.valor_pagar);
            Console.WriteLine("Se agregó: " + accesoC.fecha_creacion);*/

            //Revision
            /*Console.WriteLine("Se agregó: " + accesoC.Id);
            Console.WriteLine("Se agregó: " + accesoC.ClienteCedula);
            Console.WriteLine("Se agregó: " + accesoC.EmpleadoCedula);
            Console.WriteLine("Se agregó: " + accesoC.VehiculoPlaca);
            Console.WriteLine("Se agregó: " + accesoC.est_aceite);
            Console.WriteLine("Se agregó: " + accesoC.est_filtro_aire);
            Console.WriteLine("Se agregó: " + accesoC.est_filtro_gasolina);
            Console.WriteLine("Se agregó: " + accesoC.tipo_mantenimiento);
            Console.WriteLine("Se agregó: " + accesoC.fecha_creacion);
            Console.WriteLine("Se agregó: " + accesoC.observaciones);*/

            //Cliente
            /*Console.WriteLine("Se agregó: " + accesoC.Nombre);
            Console.WriteLine("Se agregó: " + accesoC.Apellido);
            Console.WriteLine("Se agregó: " + accesoC.Cedula);
            Console.WriteLine("Se agregó: " + accesoC.Telefono);
            Console.WriteLine("Se agregó: " + accesoC.Direccion);
            Console.WriteLine("Se agregó: " + accesoC.Correo);
            Console.WriteLine("Se agregó: " + accesoC.FechaCreacion);*/

             //Jefe
            /*Console.WriteLine("Se agregó: " + accesoC.Tipo);
            Console.WriteLine("Se agregó: " + accesoC.Placa);
            Console.WriteLine("Se agregó: " + accesoC.CliCedula);
            Console.WriteLine("Se agregó: " + accesoC.Marca);
            Console.WriteLine("Se agregó: " + accesoC.Modelo);
            Console.WriteLine("Se agregó: " + accesoC.Color);
            Console.WriteLine("Se agregó: " + accesoC.FechaCreacion);*/

        }

    }
}

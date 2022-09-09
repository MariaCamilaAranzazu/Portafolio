using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dominio.Entidades;
using Persistencia.AppRepositorios;

namespace Presentacion.Pages
{
    public class CrudEmpleado : PageModel
    {
        /*private readonly ILogger<CrudEmpleado> _logger;

        public CrudEmpleado(ILogger<CrudEmpleado> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<Empleado> repoEmpleado;
        public IEnumerable<Empleado> empleados {get;set;}

        public CrudEmpleado(IRepository<Empleado> repoEmpleado)
        {
            this.repoEmpleado = repoEmpleado;
        }

        public void OnGet()
        {
            empleados = repoEmpleado.GetAll().Result;
        }

        [BindProperty]
        public Empleado NuevoEmpleado {get;set;} 
        [BindProperty]
        public Empleado EmpleadoEditar {get;set;}
        public IActionResult OnPost()
        {
            if (ModelState.IsValid==false)
            {
                return Page();
            }
            repoEmpleado.Insert(NuevoEmpleado);
            /*NuevoAccesoC.ClienteCedula = 5100100;
            NuevoAccesoC.Usuario = "Martha";
            NuevoAccesoC.Contraseña = "Mar12345";
            repoAccesoC.Insert(NuevoAccesoC);*/
            return RedirectToPage("/CrudEmpleado");
        }

        public IActionResult OnPostDelete(int id)
        {
            var empleado = repoEmpleado.GetById(id).Result;
            if (empleado == null)
            {
                return NotFound();
            }

            repoEmpleado.Delete(empleado);
            return RedirectToPage("/CrudEmpleado");
        }

        public IActionResult OnPostEdit()
        {
            Console.WriteLine("Se encontró: " + EmpleadoEditar.Cedula);
            var empleado = repoEmpleado.GetBy(e => e.Cedula == EmpleadoEditar.Cedula).Result;
            if (empleado == null)
            {
                return NotFound();
            }
            empleado.Nombre = EmpleadoEditar.Nombre;
            empleado.Apellido = EmpleadoEditar.Apellido;
            empleado.Cedula = EmpleadoEditar.Cedula;
            empleado.CargoId = EmpleadoEditar.CargoId;
            empleado.Telefono= EmpleadoEditar.Telefono;
            empleado.Direccion = EmpleadoEditar.Direccion;
            empleado.Correo = EmpleadoEditar.Correo;
            repoEmpleado.Update(empleado);

            return RedirectToPage("/CrudEmpleado");
        }
    }
}
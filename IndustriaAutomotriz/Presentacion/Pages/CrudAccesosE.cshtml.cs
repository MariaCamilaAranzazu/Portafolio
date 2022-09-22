using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dominio.Entidades;
using Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace Presentacion.Pages
{
    [Authorize]
    public class CrudAccesosE : PageModel
    {
        private readonly IRepository<AccesoEmpleado> repoAccesoE;
        public IEnumerable<AccesoEmpleado> accesosE {get;set;}

        public CrudAccesosE(IRepository<AccesoEmpleado> repoAccesoE)
        {this.repoAccesoE = repoAccesoE;}

        public void OnGet()
        {accesosE = repoAccesoE.GetAll().Result;}

        [BindProperty]
        public AccesoEmpleado NuevoAccesoE {get;set;} 
        [BindProperty]
        public AccesoEmpleado AccesoEEditar {get;set;}

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { return Page(); }
            
            repoAccesoE.Insert(NuevoAccesoE);
            return RedirectToPage("/CrudAccesosE");
        }

        public IActionResult OnPostDelete(int id)
        {
            var accesoE = repoAccesoE.GetById(id).Result;
            if (accesoE == null)
            {return NotFound();}

            repoAccesoE.Delete(accesoE);
            return RedirectToPage("/CrudAccesosE");
        }

        public IActionResult OnPostEdit()
        {
            Console.WriteLine("Se encontró: " + AccesoEEditar.EmpleadoCedula);
            var accesoE = repoAccesoE.GetBy(ae => ae.EmpleadoCedula == AccesoEEditar.EmpleadoCedula).Result;
            if (accesoE == null)
            {return NotFound();            }
            accesoE.EmpleadoCedula = AccesoEEditar.EmpleadoCedula;
            accesoE.Contraseña = AccesoEEditar.Usuario;
            accesoE.Contraseña = AccesoEEditar.Contraseña;
            repoAccesoE.Update(accesoE);

            return RedirectToPage("/CrudAccesosE");
        }
    }
}
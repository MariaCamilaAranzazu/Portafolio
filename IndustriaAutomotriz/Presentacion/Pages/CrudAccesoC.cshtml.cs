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
    public class CrudAccesoC : PageModel
    {
        /*private readonly ILogger<CrudAccesoC> _logger;

        public CrudAccesoC(ILogger<CrudAccesoC> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<AccesoCliente> repoAccesoC;
        public IEnumerable<AccesoCliente> accesosC {get;set;}

        public CrudAccesoC(IRepository<AccesoCliente> repoAccesoC)
        {this.repoAccesoC = repoAccesoC;}

        public void OnGet()
        {accesosC = repoAccesoC.GetAll().Result;}

        [BindProperty]
        public AccesoCliente NuevoAccesoC {get;set;} 
        [BindProperty]
        public AccesoCliente AccesoCEditar {get;set;}
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { return Page(); }
            
            repoAccesoC.Insert(NuevoAccesoC);
            return RedirectToPage("/CrudAccesoC");
        }

        public IActionResult OnPostDelete(int id)
        {
            var accesoC = repoAccesoC.GetById(id).Result;
            if (accesoC == null)
            {
                return NotFound();
            }

            repoAccesoC.Delete(accesoC);
            return RedirectToPage("/CrudAccesoC");
        }

        public IActionResult OnPostEdit()
        {
            Console.WriteLine("Se encontró: " + AccesoCEditar.ClienteCedula);
            var accesoC = repoAccesoC.GetBy(ac => ac.ClienteCedula == AccesoCEditar.ClienteCedula).Result;
            if (accesoC == null)
            {
                return NotFound();
            }
            accesoC.ClienteCedula = AccesoCEditar.ClienteCedula;
            accesoC.Usuario = AccesoCEditar.Usuario;
            accesoC.Contraseña = AccesoCEditar.Contraseña;
            repoAccesoC.Update(accesoC);

            return RedirectToPage("/CrudAccesoC");
        }
    }
}
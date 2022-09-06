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
    public class Pruebas : PageModel
    {
        //private readonly ILogger<Pruebas> _logger;

        /*public Pruebas(ILogger<Pruebas> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<Cliente> repoCliente; 
        private readonly IRepository<AccesoCliente> repoAccesoC;
        public IEnumerable<Cliente> clientes {get;set;}

        public Pruebas(IRepository<Cliente> repoCliente, IRepository<AccesoCliente> repoAccesoC)
        {
            this.repoCliente = repoCliente;
            this.repoAccesoC = repoAccesoC;
        }

        public void OnGet()
        {
            clientes = repoCliente.GetAll().Result;
        }

        [BindProperty]
        public Cliente NuevoCliente {get;set;} 
        public AccesoCliente NuevoAccesoC = new AccesoCliente();

        public IActionResult OnPost()
        {
            if (ModelState.IsValid==false)
            {
                return Page();
            }
            repoCliente.Insert(NuevoCliente);
            /*NuevoAccesoC.ClienteCedula = 5100100;
            NuevoAccesoC.Usuario = "Martha";
            NuevoAccesoC.Contraseña = "Mar12345";
            repoAccesoC.Insert(NuevoAccesoC);*/
            return RedirectToPage("/Pruebas");
        }

        public IActionResult OnPostDelete(int id)
        {
            var cliente = repoCliente.GetById(id).Result;
            if (cliente == null)
            {
                return NotFound();
            }

            repoCliente.Delete(cliente);
            return RedirectToPage("/Pruebas");
        }
    }
}
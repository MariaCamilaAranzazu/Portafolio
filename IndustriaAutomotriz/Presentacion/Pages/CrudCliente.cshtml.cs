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
    public class CrudCliente : PageModel
    {
        //private readonly ILogger<CrudCliente> _logger;

        /*public CrudCliente(ILogger<CrudCliente> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<Cliente> repoCliente;

        public CrudCliente(IRepository<Cliente> repoCliente)
        { this.repoCliente = repoCliente; }
        public IEnumerable<Cliente> clientes { get; set; }

        public void OnGet()
        { clientes = repoCliente.GetAll().Result; }

        [BindProperty]
        public Cliente NuevoCliente { get; set; }
        public AccesoCliente NuevoAccesoC = new AccesoCliente();
        [BindProperty]
        public Cliente ClienteEditar { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { return Page(); }

            repoCliente.Insert(NuevoCliente);
            return RedirectToPage("./CrudCliente");
        }

        public IActionResult OnPostDelete(int id)
        {
            var cliente = repoCliente.GetById(id).Result;

            if (cliente == null)
            { return NotFound(); }

            repoCliente.Delete(cliente);
            return RedirectToPage("/CrudCliente");
        }

        public IActionResult OnPostEdit()
        {
            Console.WriteLine("Se encontró: " + ClienteEditar.Cedula);
            var cliente = repoCliente.GetBy(c => c.Cedula == ClienteEditar.Cedula).Result;

            if (cliente == null)
            { return NotFound(); }

            cliente.Nombre = ClienteEditar.Nombre;
            cliente.Apellido = ClienteEditar.Apellido;
            cliente.Cedula = ClienteEditar.Cedula;
            cliente.Telefono = ClienteEditar.Telefono;
            cliente.Direccion = ClienteEditar.Direccion;
            cliente.Correo = ClienteEditar.Correo;
            repoCliente.Update(cliente);

            return RedirectToPage("/CrudCliente");
        }
    }
}
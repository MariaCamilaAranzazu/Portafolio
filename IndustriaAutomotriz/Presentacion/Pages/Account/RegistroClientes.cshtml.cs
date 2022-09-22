using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dominio.Entidades;
using Persistencia.AppRepositorios;

namespace Presentacion.Pages.Account
{
    public class RegistroClientes : PageModel
    {

        private readonly IRepository<AccesoCliente> repoAcessoC;
        private readonly IRepository<Cliente> repoCliente;
        private readonly IRepository<AccesoEmpleado> repoAcessoE;

        public RegistroClientes(
            IRepository<AccesoCliente> repoAcessoC, 
            IRepository<Cliente> repoCliente,
            IRepository<AccesoEmpleado> repoAcessoE,
            IRepository<Cliente> repoEmpleado)
        {
            this.repoAcessoC = repoAcessoC;
            this.repoCliente = repoCliente;
            this.repoAcessoE = repoAcessoE;
        }

        [BindProperty]
        public int cedula { get; set; }

        [BindProperty]
        public Cliente NuevoCliente { get; set; }

        [BindProperty]
        public AccesoCliente NuevoAccesoC {get; set;}
        public AccesoCliente accesoCEncontrado { get; set; }

        public bool clienteNulo{ get; set; } = false;
        public bool clienteExiste{get; set;} = true;

        public IActionResult OnPost()
        {
            System.Console.WriteLine("primer marcador");
            var accesoC = repoAcessoC.GetBy(ac => ac.ClienteCedula == cedula).Result;

            //System.Console.WriteLine("Se encontró: " + accesoC.)

            if (accesoC != null)
            {
               return Page();
            }

            else if (accesoC == null)
            {
                var cliente = repoCliente.GetBy(c => c.Cedula == cedula).Result;

                if (cliente != null)
                {
                    clienteNulo = true;
                    return Page();
                }
                else if (cliente == null)
                {
                    System.Console.WriteLine("llega hasta aca");
                    clienteExiste = false;
                    return Page();
                }
               
            }

            return RedirectToPage("/Account/Login");
        }

        public IActionResult OnPostReg()
        {
            repoCliente.Insert(NuevoCliente);

            var accesoCGuardar = new AccesoCliente();

            accesoCGuardar.ClienteCedula = NuevoCliente.Cedula;
            accesoCGuardar.Usuario = NuevoAccesoC.Usuario;
            accesoCGuardar.Contraseña = NuevoAccesoC.Contraseña;

            repoAcessoC.Insert(accesoCGuardar);

            return RedirectToPage("/Account/Login");
        }
    }
}
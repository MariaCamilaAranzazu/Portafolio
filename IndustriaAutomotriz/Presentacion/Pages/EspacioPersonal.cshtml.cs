using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Dominio.Entidades;
using Persistencia.AppRepositorios;

namespace Presentacion.Pages
{
    [Authorize(Policy = "PerteneceACliente")]
    public class EspacioPersonal : PageModel
    {
        private readonly IRepository<AccesoCliente> repoAcessoC;
        private readonly IRepository<Cliente> repoCliente;

        public EspacioPersonal(IRepository<AccesoCliente> repoAcessoC, IRepository<Cliente> repoCliente)
        {this.repoAcessoC = repoAcessoC; this.repoCliente = repoCliente;}

        public Cliente datosEncontrados { get; set; }
        public void OnGet()
        {
            var accesoC = repoAcessoC.GetBy(ac => ac.Usuario == User.Identity.Name).Result;
            datosEncontrados = repoCliente.GetBy(c => c.Cedula == accesoC.ClienteCedula).Result;
        }
    }
}
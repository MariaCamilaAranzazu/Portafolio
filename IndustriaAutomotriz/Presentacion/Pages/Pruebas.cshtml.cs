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

        private readonly IRepository<AccesoCliente> repositoryAC; 
        public IEnumerable<AccesoCliente> accesosClientes {get; set;}

        public Pruebas(IRepository<AccesoCliente> repositoryAC)
        {
            this.repositoryAC = repositoryAC;
        }

        public void OnGet()
        {
            accesosClientes = repositoryAC.GetAll().Result;
        }
    }
}
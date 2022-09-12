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
    public class MisOrdenes : PageModel
    {
        /*private readonly ILogger<MisOrdenes> _logger;

        public MisOrdenes(ILogger<MisOrdenes> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<OrdenServicio> repoOrdenes;
        public MisOrdenes(IRepository<OrdenServicio> OrdenesdelRep){
            this.repoOrdenes=OrdenesdelRep;
        }
        [BindProperty]
        public int revId {get;set;}
        public IEnumerable<OrdenServicio> OrdenesEncontradas {get;set;}
        

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var ordenesGen=repoOrdenes.GetAll().Result;
            List<OrdenServicio> ordenesC = new List<OrdenServicio>();
            foreach (var orden in ordenesGen)
            {
                if (orden.EmpCedula==revId)
                {
                    ordenesC.Add(orden);
                }
                
            }

            OrdenesEncontradas=ordenesC;
            return Page();
        }

    }
}
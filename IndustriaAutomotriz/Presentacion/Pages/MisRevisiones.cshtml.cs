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
    public class MisRevisiones : PageModel
    {
        /*private readonly ILogger<MisRevisiones> _logger;

        public MisRevisiones(ILogger<MisRevisiones> logger)
        {
            _logger = logger;
        }*/

        [BindProperty]
        public int cedula {get; set;}
        public string aviso {get;set;}
        public string aviso2 {get;set;}

        private readonly IRepository<Revision> repoRevision;

        public IEnumerable<Revision> RevisionesEncontradas { get; set; }

        public MisRevisiones(IRepository<Revision> repoRevision)
        {
            this.repoRevision = repoRevision;

        }

        public void OnGet()
        {

            aviso = "Hola Mundo";


            /*if (ClienteEncontrado != null)
            {
                Console.WriteLine("Se encontró: " + ClienteEncontrado.Nombre);
                Console.WriteLine("Se encontró: " + ClienteEncontrado.Cedula);
                Console.WriteLine("Se encontró: " + ClienteEncontrado.Correo);

            }*/
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            var revisionesGen = repoRevision.GetAll().Result;
            List<Revision> revisionesC = new List<Revision>();
            

            foreach (var revision in revisionesGen)
            {
                if (revision.EmpleadoCedula == cedula)
                {
                    revisionesC.Add(revision);
                }
                
            }

            RevisionesEncontradas = revisionesC;

            /*Console.WriteLine("Se encontró: " + cliente.Nombre);
            Console.WriteLine("Se encontró: " + cliente.Cedula);
            Console.WriteLine("Se encontró: " + cliente.Correo);*/
            aviso2= "hola desde post";
            return Page();
        }



    }
}
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
    public class CrudRevision : PageModel
    {
        /*private readonly ILogger<CrudRevision> _logger;

        public CrudRevision(ILogger<CrudRevision> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<Revision> repoRevision;
        public IEnumerable<Revision> revisiones {get;set;}

        public CrudRevision(IRepository<Revision> repoRevision)
        {
            this.repoRevision = repoRevision;
        }

        public void OnGet()
        {
            revisiones = repoRevision.GetAll().Result;
        }

        [BindProperty]
        public Revision NuevaRevision {get;set;} 
        [BindProperty]
        public Revision RevisionEditar {get;set;}

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { return Page(); }

            repoRevision.Insert(NuevaRevision);
            return RedirectToPage("/CrudRevision");
        }

        public IActionResult OnPostDelete(int id)
        {
            var revision = repoRevision.GetById(id).Result;
            if (revision == null)
            {
                return NotFound();
            }
            repoRevision.Delete(revision);
            return RedirectToPage("/CrudRevision");
        }

        public IActionResult OnPostEdit()
        {
            Console.WriteLine("Se encontró: " + RevisionEditar.Id);
            var revision = repoRevision.GetById(RevisionEditar.Id).Result;
            if (revision == null)
            {
                return NotFound();
            }
            revision.ClienteCedula = RevisionEditar.ClienteCedula;
            revision.EmpleadoCedula = RevisionEditar.EmpleadoCedula;
            revision.VehiculoPlaca = RevisionEditar.VehiculoPlaca;
            revision.EstAceite = RevisionEditar.EstAceite;
            revision.EstFiltroAire= RevisionEditar.EstFiltroAire;
            revision.EstFiltroGasolina = RevisionEditar.EstFiltroGasolina;
            revision.TipoMantenimiento = RevisionEditar.TipoMantenimiento;
            revision.Observaciones = RevisionEditar.Observaciones;
            repoRevision.Update(revision);

            return RedirectToPage("/CrudRevision");
        }
    }
}
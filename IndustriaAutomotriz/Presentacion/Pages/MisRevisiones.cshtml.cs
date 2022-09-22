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
    public class MisRevisiones : PageModel
    {
        private readonly IRepository<AccesoCliente> repoAcessoC;
        private readonly IRepository<Revision> repoRevision;
        private readonly IRepository<Cliente> repoCliente;

        public IEnumerable<Revision> RevisionesEncontradas { get; set; }

        public MisRevisiones(IRepository<Revision> repoRevision, IRepository<Cliente> repoCliente, IRepository<AccesoCliente> repoAcessoC)
        {
            this.repoRevision = repoRevision;
            this.repoCliente = repoCliente;
            this.repoAcessoC = repoAcessoC;
        }

        public void OnGet()
        {
            var accesoC = repoAcessoC.GetBy(ac => ac.Usuario == User.Identity.Name).Result;
            var cliente = repoCliente.GetBy(c => c.Cedula == accesoC.ClienteCedula).Result;

            if (cliente != null)
            {
                var revisionesGen = repoRevision.GetAll().Result;
                List<Revision> revisionesC = new List<Revision>();
                foreach (var revision in revisionesGen)
                {
                    if (revision.ClienteCedula == cliente.Cedula)
                    {
                        revisionesC.Add(revision);
                    }
                }
                RevisionesEncontradas = revisionesC;
            }
        }
    }
}
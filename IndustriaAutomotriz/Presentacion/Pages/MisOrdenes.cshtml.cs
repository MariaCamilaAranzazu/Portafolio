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
    public class MisOrdenes : PageModel
    {
        private readonly IRepository<AccesoCliente> repoAcessoC;
        private readonly IRepository<Cliente> repoCliente;
        private readonly IRepository<OrdenServicio> repoOrdenes;
        private readonly IRepository<Revision> repoRevisiones;
        public MisOrdenes(IRepository<OrdenServicio> repoOrdenes
            , IRepository<AccesoCliente> repoAcessoC
            , IRepository<Cliente> repoCliente
            , IRepository<Revision> repoRevisiones)
        {
            this.repoOrdenes = repoOrdenes;
            this.repoCliente = repoCliente;
            this.repoAcessoC = repoAcessoC;
            this.repoRevisiones = repoRevisiones;
        }

        [BindProperty]
        public int revId { get; set; }
        public IEnumerable<OrdenServicio> OrdenesEncontradas { get; set; }

        public void OnGet()
        {
            var accesoC = repoAcessoC.GetBy(ac => ac.Usuario == User.Identity.Name).Result;
            var cliente = repoCliente.GetBy(c => c.Cedula == accesoC.ClienteCedula).Result;

            if (cliente != null)
            {
                var revisiones = repoRevisiones.GetAll().Result;

                List<int> idRevisionesC = new List<int>();
                List<OrdenServicio> ordenesC = new List<OrdenServicio>();

                foreach (var revision in revisiones)
                {
                    if (revision.ClienteCedula == cliente.Cedula)
                    { idRevisionesC.Add(revision.Id); }
                }

                if (idRevisionesC != null)
                {
                    foreach (var id in idRevisionesC)
                    {
                        var ordenEncontrada = repoOrdenes.GetBy(o => o.RevId == id).Result;
                        if (ordenEncontrada != null)
                        { ordenesC.Add(ordenEncontrada); }
                    }
                    OrdenesEncontradas = ordenesC;

                }
            }
        }
    }
}
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
    public class CrudOrdenes : PageModel
    {
        /*private readonly ILogger<CrudOrdenes> _logger;

        public CrudOrdenes(ILogger<CrudOrdenes> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<OrdenServicio> repoOrden;
        public IEnumerable<OrdenServicio> ordenes {get;set;}

        public CrudOrdenes(IRepository<OrdenServicio> repoOrden)
        {
            this.repoOrden = repoOrden;
        }

        public void OnGet()
        {
            ordenes = repoOrden.GetAll().Result;
        }

        [BindProperty]
        public OrdenServicio NuevaOrden {get;set;} 
        [BindProperty]
        public OrdenServicio OrdenEditar {get;set;}
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { return Page(); }
            
            repoOrden.Insert(NuevaOrden);
            return RedirectToPage("/CrudOrdenes");
        }

        public IActionResult OnPostDelete(int id)
        {
            var orden = repoOrden.GetById(id).Result;
            if (orden == null)
            {
                return NotFound();
            }
            repoOrden.Delete(orden);
            return RedirectToPage("/CrudOrdenes");
        }

        public IActionResult OnPostEdit()
        {
            Console.WriteLine("Se encontró: " + OrdenEditar.RevId);
            var orden = repoOrden.GetBy(o => o.RevId == OrdenEditar.RevId).Result;
            if (orden == null)
            {
                return NotFound();
            }
            orden.RevId = OrdenEditar.RevId;
            orden.EmpCedula = OrdenEditar.EmpCedula;
            orden.ActSoftware = OrdenEditar.ActSoftware;
            orden.InstRepuestos = OrdenEditar.InstRepuestos;
            orden.CostoRespuestos= OrdenEditar.CostoRespuestos;
            orden.CostoServicio = OrdenEditar.CostoServicio;
            orden.TotalPagar = OrdenEditar.TotalPagar;
            orden.Observaciones = OrdenEditar.Observaciones;
            repoOrden.Update(orden);

            return RedirectToPage("/CrudOrdenes");
        }
    }
}
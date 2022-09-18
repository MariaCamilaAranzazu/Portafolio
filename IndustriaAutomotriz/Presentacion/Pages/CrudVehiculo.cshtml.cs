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
    public class CrudVehiculo : PageModel
    {
        /*private readonly ILogger<CrudVehiculo> _logger;

        public CrudVehiculo(ILogger<CrudVehiculo> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<Vehiculo> repoVehiculo;
        public IEnumerable<Vehiculo> vehiculos {get;set;}

        public CrudVehiculo(IRepository<Vehiculo> repoVehiculo)
        {
            this.repoVehiculo = repoVehiculo;
        }

        public void OnGet()
        {
            vehiculos = repoVehiculo.GetAll().Result;
        }

        [BindProperty]
        public Vehiculo NuevoVehiculo {get;set;} 
        [BindProperty]
        public Vehiculo VehiculoEditar {get;set;}

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { return Page(); }
            
            repoVehiculo.Insert(NuevoVehiculo);
            return RedirectToPage("/CrudVehiculo");
        }

        public IActionResult OnPostDelete(int id)
        {
            var vehiculo = repoVehiculo.GetById(id).Result;
            if (vehiculo == null)
            {
                return NotFound();
            }
            repoVehiculo.Delete(vehiculo);
            return RedirectToPage("/CrudVehiculo");
        }

        public IActionResult OnPostEdit()
        {
            Console.WriteLine("Se encontró: " + VehiculoEditar.Placa);
            var vehiculo = repoVehiculo.GetBy(v => v.Placa == VehiculoEditar.Placa).Result;
            if (vehiculo == null)
            {
                return NotFound();
            }
            vehiculo.Tipo = VehiculoEditar.Tipo;
            vehiculo.Placa = VehiculoEditar.Placa;
            vehiculo.CliCedula = VehiculoEditar.CliCedula;
            vehiculo.Marca = VehiculoEditar.Marca;
            vehiculo.Modelo= VehiculoEditar.Modelo;
            vehiculo.Color = VehiculoEditar.Color;
            repoVehiculo.Update(vehiculo);

            return RedirectToPage("/CrudVehiculo");
        }
    }
}
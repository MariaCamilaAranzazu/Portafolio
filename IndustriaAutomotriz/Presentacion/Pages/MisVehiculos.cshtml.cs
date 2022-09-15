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
    public class MisVehiculos : PageModel
    {
        /*private readonly ILogger<MisVehículos> _logger;

        public MisVehículos(ILogger<MisVehículos> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepository<Vehiculo> repoVehiculo;
        public MisVehiculos(IRepository<Vehiculo> repoVehiculo){
            this.repoVehiculo=repoVehiculo;
        }
        [BindProperty]
        public int cedula {get;set;}
        public IEnumerable<Vehiculo> VehiculosEncontrados {get;set;}

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var vehiculos=repoVehiculo.GetAll().Result;
            List<Vehiculo> vehiculosC = new List<Vehiculo>();
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.CliCedula==cedula)
                {
                    vehiculosC.Add(vehiculo);
                }
                
            }
            VehiculosEncontrados=vehiculosC;
            return Page();
        }
    }
}
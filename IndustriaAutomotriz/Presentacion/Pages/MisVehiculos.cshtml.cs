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
    public class MisVehiculos : PageModel
    {
        private readonly IRepository<AccesoCliente> repoAcessoC;
        private readonly IRepository<Vehiculo> repoVehiculo;
        private readonly IRepository<Cliente> repoCliente;
        public MisVehiculos(IRepository<Vehiculo> repoVehiculo, IRepository<Cliente> repoCliente, IRepository<AccesoCliente> repoAcessoC)
        {
            this.repoVehiculo = repoVehiculo;
            this.repoCliente = repoCliente;
            this.repoAcessoC = repoAcessoC;
        }
        public IEnumerable<Vehiculo> VehiculosEncontrados { get; set; }

        public void OnGet()
        {
            var accesoC = repoAcessoC.GetBy(ac => ac.Usuario == User.Identity.Name).Result;
            var cliente = repoCliente.GetBy(c => c.Cedula == accesoC.ClienteCedula).Result;

            if (cliente != null)
            {
                var vehiculos = repoVehiculo.GetAll().Result;
                List<Vehiculo> vehiculosC = new List<Vehiculo>();
                foreach (var vehiculo in vehiculos)
                {
                    if (vehiculo.CliCedula == cliente.Cedula)
                    {
                        vehiculosC.Add(vehiculo);
                    }
                }
                VehiculosEncontrados = vehiculosC;
            }

        }
    }
}
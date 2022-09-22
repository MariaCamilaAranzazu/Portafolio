using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Dominio.Entidades;
using Persistencia.AppRepositorios;

namespace Presentacion.Pages.Account
{
    public class Login : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        private readonly IRepository<AccesoCliente> repoAccesoC;
        private readonly IRepository<Cliente> repoCliente;
        private readonly IRepository<AccesoEmpleado> repoAccesoE;
        private readonly IRepository<Empleado> repoEmpleado;

        public Login(IRepository<AccesoCliente> repoAccesoC,
                    IRepository<Cliente> repoCliente,
                    IRepository<AccesoEmpleado> repoAccesoE,
                    IRepository<Empleado> repoEmpleado)
        {
            this.repoAccesoC = repoAccesoC;
            this.repoCliente = repoCliente;
            this.repoAccesoE = repoAccesoE;
            this.repoEmpleado = repoEmpleado;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            { return Page(); }

            var accesoC = repoAccesoC.GetBy(ac => ac.Usuario == Credential.UserName).Result;
            var accesoE = repoAccesoE.GetBy(ae => ae.Usuario == Credential.UserName).Result;

            if (accesoC != null && accesoC.Contraseña == Credential.Password)
            {
                var cliente = repoCliente.GetBy(c => c.Cedula == accesoC.ClienteCedula).Result;
                var claims = new List<Claim>{
                    new Claim(ClaimTypes.Name, accesoC.Usuario),
                    new Claim(ClaimTypes.Email, cliente.Correo),
                    new Claim("Department", "Cliente")
                };

                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/EspacioPersonal");
            }

            else if (accesoE != null && accesoE.Contraseña == Credential.Password)
            {
                var empleado = repoEmpleado.GetBy(e => e.Cedula == accesoE.EmpleadoCedula).Result;

                if (empleado.CargoId == 1)
                {
                    var claims = new List<Claim>{
                        new Claim(ClaimTypes.Name, accesoE.Usuario),
                        new Claim(ClaimTypes.Email, empleado.Correo),
                        new Claim("Department", "Tecnico")
                    };

                    var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                    return RedirectToPage("/EspacioTrabajo");
                }

                else if (empleado.CargoId == 2)
                {
                    var claims = new List<Claim>{
                        new Claim(ClaimTypes.Name, accesoE.Usuario),
                        new Claim(ClaimTypes.Email, empleado.Correo),
                        new Claim("Department", "Gestor")
                    };

                    var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                    return RedirectToPage("/GestionAccesos");
                }

                else if (empleado.CargoId == 3)
                {
                    var claims = new List<Claim>{
                            new Claim(ClaimTypes.Name, accesoE.Usuario),
                            new Claim(ClaimTypes.Email, empleado.Correo),
                            new Claim("Department", "Administrador")
                        };

                    var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                    return RedirectToPage("/Cruds");
                }

                return RedirectToPage("/EspacioPersonal");
            }
            return Page();
        }
    }

    public class Credential
    {
        [Required]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
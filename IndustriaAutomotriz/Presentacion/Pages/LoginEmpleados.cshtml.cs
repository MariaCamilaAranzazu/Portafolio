using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Presentacion.Pages
{
    public class LoginEmpleados : PageModel
    {
        private readonly ILogger<LoginEmpleados> _logger;

        public LoginEmpleados(ILogger<LoginEmpleados> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
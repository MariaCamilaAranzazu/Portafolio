using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Presentacion.Pages
{
    public class EspacioTrabajo : PageModel
    {
        private readonly ILogger<EspacioTrabajo> _logger;

        public EspacioTrabajo(ILogger<EspacioTrabajo> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
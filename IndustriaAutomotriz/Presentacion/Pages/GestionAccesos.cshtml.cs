using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace Presentacion.Pages
{
    [Authorize(Policy="PerteneceAGestor")]
    public class GestionAccesos : PageModel
    {
        private readonly ILogger<GestionAccesos> _logger;

        public GestionAccesos(ILogger<GestionAccesos> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Presentacion.Pages
{
    public class Revisiones : PageModel
    {
        private readonly ILogger<Revisiones> _logger;

        public Revisiones(ILogger<Revisiones> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
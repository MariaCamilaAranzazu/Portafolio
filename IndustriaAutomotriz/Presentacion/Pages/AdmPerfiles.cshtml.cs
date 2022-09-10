using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Presentacion.Pages
{
    public class AdmPerfiles : PageModel
    {
        private readonly ILogger<AdmPerfiles> _logger;

        public AdmPerfiles(ILogger<AdmPerfiles> logger)
        {
            _logger = logger;
        }
        
        


        public void OnGet()
        {
        }
    }
}
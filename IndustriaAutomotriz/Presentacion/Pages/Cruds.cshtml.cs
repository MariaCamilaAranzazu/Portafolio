using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Presentacion.Pages
{
    public class Cruds : PageModel
    {
        private readonly ILogger<Cruds> _logger;

        public Cruds(ILogger<Cruds> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
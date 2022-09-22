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
    [Authorize(Policy = "PerteneceATecnico")]
    
    public class EspacioTrabajo : PageModel
    {
        public void OnGet()
        {
        }
    }
}
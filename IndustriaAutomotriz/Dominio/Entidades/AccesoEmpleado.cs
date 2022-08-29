using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class AccesoEmpleado
    {
        public int Id {get;set;}
        public int EmpleadoCedula {get;set;}
        public string contraseña {get;set}
        public string fecha_registro {get;set;}
    }
}
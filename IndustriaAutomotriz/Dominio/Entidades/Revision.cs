using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Revision
    {
        public int Id {get;set;}
        public int ClienteCedula {get;set;}
        public int EmpleadoCedula {get;set;}
        public string VehiculoPlaca {get;set;}
        public string est_aceite {get;set;}
        public string est_filtro_aire {get;set;}
        public string est_filtro_gasolina {get;set;}
        public string tipo_mantenimiento {get;set;}
        public string fecha {get;set;}
        public string observaciones {get;set;}
    }
}
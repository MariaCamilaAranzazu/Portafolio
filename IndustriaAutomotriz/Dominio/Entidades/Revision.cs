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
        public string EstAceite {get;set;}
        public string EstFiltroAire {get;set;}
        public string EstFiltroGasolina {get;set;}
        public string TipoMantenimiento {get;set;}
        public string FechaCreacion {get;set;}
        public string Observaciones {get;set;}
    }
}
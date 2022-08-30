using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Repuesto
    {
        public int Id {get;set;}
        public string nombre {get;set;}
        public int cantidad {get;set;}
        public int precio_unidad {get;set;}
        public string fecha_creacion {get;set;}
    }
}
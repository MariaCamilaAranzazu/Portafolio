using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Repuesto
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public int Cantidad {get;set;}
        public int PrecioUnidad {get;set;}
        public string FechaCreacion {get;set;}
    }
}
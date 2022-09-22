using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Repuesto
    {
        public Repuesto()
        {FechaCreacion = DateTime.Now;}
        public int Id {get;set;}

        [StringLength(50)]
        public string Nombre {get;set;}

        public int Cantidad {get;set;}

        public double PrecioUnidad {get;set;}

        public DateTime FechaCreacion {get;set;}
    }
}
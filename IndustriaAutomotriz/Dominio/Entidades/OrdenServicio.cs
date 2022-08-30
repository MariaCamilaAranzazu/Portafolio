using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class OrdenServicio
    {
        public int Id {get;set;}
        public int rev_id {get;set;}
        public int emp_cedula {get;set;}
        public string act_software {get;set;}
        public string inst_repuestos {get;set;}
        public double costo_respuestos {get;set;}
        public double costo_servicio {get;set;}
        public double total_pagar {get;set;}
        public string fecha_creacion {get;set;}
        public string observaciones {get;set;}
    }
}
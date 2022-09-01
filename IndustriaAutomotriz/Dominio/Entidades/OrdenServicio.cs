using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class OrdenServicio
    {
        public int Id {get;set;}
        public int RevId {get;set;}
        public int EmpCedula {get;set;}
        public string ActSoftware {get;set;}
        public string InstRepuestos {get;set;}
        public double CostoRespuestos {get;set;}
        public double CostoServicio {get;set;}
        public double TotalPagar {get;set;}
        public string FechaCreacion {get;set;}
        public string Observaciones {get;set;}
    }
}
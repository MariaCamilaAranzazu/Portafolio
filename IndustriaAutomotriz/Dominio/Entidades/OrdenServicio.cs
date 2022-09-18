using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class OrdenServicio
    {
        public OrdenServicio()
        {FechaCreacion = DateTime.Now;}
        public int Id {get;set;}

        public int RevId {get;set;}

        public int EmpCedula {get;set;}

        [StringLength(50)]
        public string ActSoftware {get;set;}

        [StringLength(50)]
        public string InstRepuestos {get;set;}

        public double CostoRespuestos {get;set;}

        public double CostoServicio {get;set;}

        public double TotalPagar {get;set;}

        public DateTime FechaCreacion {get;set;}

        [StringLength(240)]
        public string Observaciones {get;set;}
    }
}
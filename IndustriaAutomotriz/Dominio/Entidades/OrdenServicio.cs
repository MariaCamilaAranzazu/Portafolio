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
        public int Id {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int RevId {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int EmpCedula {get;set;}
        [Required,StringLength(100)]
        public string ActSoftware {get;set;}
        [Required,StringLength(100)]
        public string InstRepuestos {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public double CostoRespuestos {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public double CostoServicio {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public double TotalPagar {get;set;}
        [Required]
        public DateTime FechaCreacion {get;set;}
        [Required,StringLength(460)]
        public string Observaciones {get;set;}
    }
}
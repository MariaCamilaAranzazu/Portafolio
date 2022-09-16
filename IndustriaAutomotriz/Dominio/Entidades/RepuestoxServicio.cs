using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class RepuestoxServicio
    {
        public int Id {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int OrdenServicioId {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int RepuestoId {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int CantActual {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int CantSalEnt {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public double ValorPagar {get;set;}
        [Required]
        public DateTime FechaCreacion {get;set;}
    }
}
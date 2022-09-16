using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Cargo
    {
        public int Id {get;set;}
        [Required,StringLength(100)]
        public string Nombre {get;set;}
        [Required]
        public DateTime FechaCreacion {get;set;}
    }
}
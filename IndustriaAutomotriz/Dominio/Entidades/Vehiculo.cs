using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Vehiculo
    {
        public int Id {get;set;}
        [Required,StringLength(100)]
        public string Tipo {get;set;}
        [Required,StringLength(100)]
        public string Placa {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int CliCedula {get;set;}
        [Required,StringLength(100)]
        public string Marca {get;set;}
        [Required,StringLength(100)]
        public string Modelo {get;set;}
        [Required,StringLength(100)]
        public string Color {get;set;}
        [Required]
        public DateTime FechaCreacion {get;set;}
    }
}
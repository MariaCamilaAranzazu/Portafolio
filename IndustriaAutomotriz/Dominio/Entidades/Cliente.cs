using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public int Id {get;set;}
        [Required,StringLength(100)]
        public string Nombre {get;set;}
        [Required,StringLength(100)]
        public string Apellido {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int Cedula {get;set;}
        [Required,Range(1,91000000000000,ErrorMessage="valor de 1 a 91000000000000")]
        public long Telefono {get;set;}
        [Required,StringLength(100)]
        public string Direccion {get;set;}
        [Required,StringLength(100)]
        public string Correo {get;set;}
        public DateTime FechaCreacion {get;set;}
    }
}
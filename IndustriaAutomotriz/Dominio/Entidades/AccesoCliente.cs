using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class AccesoCliente
    {
        public int Id {get;set;}
        [Required,Range(1,2100000000,ErrorMessage="valor de 1 a 2100000000")]
        public int ClienteCedula {get;set;}
        [Required,StringLength(100)]
        public string Usuario {get;set;}
        [Required,StringLength(100)]
        public string Contraseña {get;set;}
        [Required]
        public DateTime FechaCreacion{get;set;}
    }
}
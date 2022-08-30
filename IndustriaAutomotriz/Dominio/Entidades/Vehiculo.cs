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

        public string tipo {get;set;}
        [Key]
        public string Placa {get;set;}
        public int cli_cedula {get;set;}
        public string marca {get;set;}
        public string modelo {get;set;}
        public string color {get;set;}
        public string fecha_creacion {get;set;}
    }
}
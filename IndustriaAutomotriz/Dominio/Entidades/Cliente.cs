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
        public string nombre {get;set;}
        public string apellido {get;set;}
        [Key]
        public int Cedula {get;set;}
        public int telefono {get;set;}
        public string direccion {get;set;}
        public string correo {get;set;}
        public string fecha_creacion {get;set;}
    }
}
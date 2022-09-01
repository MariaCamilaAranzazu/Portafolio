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
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public int Cedula {get;set;}
        public int Telefono {get;set;}
        public string Direccion {get;set;}
        public string Correo {get;set;}
        public string FechaCreacion {get;set;}
    }
}
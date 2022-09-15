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
        //[Required(ErrorMessage="Se requiere un Nombre"),StringLength(100)]
        public string Nombre {get;set;}
        //[Required(ErrorMessage="Se requiere un Apellido"),StringLength(100)]
        public string Apellido {get;set;}
        //Required(ErrorMessage="Se requiere la Cédula"),StringLength(100)]
        public int Cedula {get;set;}
        public int Telefono {get;set;}
        //[Required(ErrorMessage="Se requiere una dirección"),StringLength(100)]
        public string Direccion {get;set;}
        //[Required(ErrorMessage="Se requiere un correo"),StringLength(100)]
        public string Correo {get;set;}
        public string FechaCreacion {get;set;}
    }
}
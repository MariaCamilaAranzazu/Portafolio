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
        public string Tipo {get;set;}
        public string Placa {get;set;}
        public int CliCedula {get;set;}
        public string Marca {get;set;}
        public string Modelo {get;set;}
        public string Color {get;set;}
        public string FechaCreacion {get;set;}
    }
}
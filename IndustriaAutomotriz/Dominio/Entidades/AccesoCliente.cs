using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class AccesoCliente
    {
        public int Id {get;set;}
        public int ClienteCedula {get;set;}
        public string Usuario {get;set;}
        public string Contraseña {get;set;}
        public string FechaCreacion{get;set;}
    }
}
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
        public string usuario {get;set;}
        public string contraseña {get;set;}
        public string fecha_creacion{get;set;}
    }
}
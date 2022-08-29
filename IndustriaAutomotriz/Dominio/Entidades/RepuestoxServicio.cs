using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class RepuestoxServicio
    {
        public int Id {get;set;}
        public int OrdenServicioId {get;set;}
        public int RepuestoId {get;set;}
        public int cant_actual {get;set;}
        public int cant_sal_ent {get;set;}
        public int valor_pagar {get;set;}
        public string fecha {get;set;}
    }
}
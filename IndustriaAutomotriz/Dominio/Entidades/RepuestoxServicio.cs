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
        public int CantActual {get;set;}
        public int CantSalEnt {get;set;}
        public int ValorPagar {get;set;}
        public string FechaCreacion {get;set;}
    }
}
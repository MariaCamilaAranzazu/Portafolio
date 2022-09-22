using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class RepuestoxServicio
    {
        public RepuestoxServicio()
        { FechaCreacion = DateTime.Now; }
        public int Id { get; set; }

        public int OrdenServicioId { get; set; }

        public int RepuestoId { get; set; }

        public int CantActual { get; set; }

        public int CantSalEnt { get; set; }

        public double ValorPagar { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
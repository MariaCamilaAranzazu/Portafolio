using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Revision
    {
        public Revision()
        { FechaCreacion = DateTime.Now; }
        public int Id { get; set; }

        public int ClienteCedula { get; set; }

        public int EmpleadoCedula { get; set; }

        [StringLength(50)]
        public string VehiculoPlaca { get; set; }

        [StringLength(50)]
        public string EstAceite { get; set; }

        [StringLength(50)]
        public string EstFiltroAire { get; set; }

        [StringLength(50)]
        public string EstFiltroGasolina { get; set; }

        [StringLength(50)]
        public string TipoMantenimiento { get; set; }

        public DateTime FechaCreacion { get; set; }

        [StringLength(240)]
        public string Observaciones { get; set; }
    }
}
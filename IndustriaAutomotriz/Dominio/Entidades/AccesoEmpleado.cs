using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class AccesoEmpleado
    {
        public AccesoEmpleado()
        { FechaCreacion = DateTime.Now; }

        public int Id { get; set; }

        public int EmpleadoCedula { get; set; }

        [StringLength(50)]
        public string Contraseña { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
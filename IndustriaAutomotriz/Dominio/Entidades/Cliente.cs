using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public Cliente()
        { FechaCreacion = DateTime.Now; }

        public int Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        public int Cedula { get; set; }

        public long Telefono { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
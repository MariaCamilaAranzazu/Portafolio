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
        public Vehiculo()
        { FechaCreacion = DateTime.Now; }
        public int Id { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string Placa { get; set; }

        public int CliCedula { get; set; }

        [StringLength(50)]
        public string Marca { get; set; }

        [StringLength(50)]
        public string Modelo { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
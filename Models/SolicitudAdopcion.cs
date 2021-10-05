using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efdemo.Models
{
    public class SolicitudAdopcion
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; }

        public string Direccion { get; set; }

        public string DescripcionEspacio { get; set; }
    }
}
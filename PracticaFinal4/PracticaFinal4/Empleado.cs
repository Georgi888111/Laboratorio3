using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal4
{
    class Empleado
    {
        private long cuit;
        private String apellido;
        private String nombre;
        private Sector sector;

        public long Cuit { get => cuit; set => cuit = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal Sector Sector { get => sector; set => sector = value; }
    }
}

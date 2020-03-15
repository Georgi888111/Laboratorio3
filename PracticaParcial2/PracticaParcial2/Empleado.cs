using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    class Empleado
    {
        private int id;
        private long cuit;
        private string apellido;
        private string nombre;
        private Sector sector;

        public int Id { get => id; set => id = value; }
        public long Cuit { get => cuit; set => cuit = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

    }
}

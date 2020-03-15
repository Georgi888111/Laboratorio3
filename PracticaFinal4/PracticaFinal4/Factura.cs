using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal4
{
    class Factura
    {
        private int id;
        private String fecha;
        private double total;
        private List<Detalle> detalles = new List<Detalle>();

        public int Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public double Total { get => total; set => total = value; }
        internal List<Detalle> Detalles { get => detalles; set => detalles = value; }
    }
}

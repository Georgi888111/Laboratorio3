using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal4
{
    class Detalle
    {
        private int id;
        private double subtotal;
        private int cantidad;
        private int idArticulo;
        private int idFactura;
        private List<Articulo> articulos = new List<Articulo>();

        public int Id { get => id; set => id = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
       
        public int IdArticulo { get => idArticulo; set => idArticulo = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal List<Articulo> Articulos { get => articulos; set => articulos = value; }
    }
}

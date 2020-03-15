using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lab___Crespo
{
    class Deposito
    {
        private string nombre;
        private string domicilio;
        private List<Articulo> articulos = new List<Articulo>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        internal List<Articulo> Articulos { get => articulos; set => articulos = value; }

        public List<Articulo> articulosBajoStock()
        {
            List<Articulo> articulosStock = new List<Articulo>();
            foreach(Articulo a in articulos)
            {
                if (a.StockTotal <= a.StockMinimo)
                {
                    articulosStock.Add(a);
                }
            }

            return articulosStock;
        }
    }
}

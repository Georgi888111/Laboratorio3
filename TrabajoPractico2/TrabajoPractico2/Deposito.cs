using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Deposito
    {
        private String nombre;
        private String domicilio;
        private List<Articulo> articulos = new List<Articulo>();

      
        public List<Articulo> articulosBajoStock()

        {
            List<Articulo> articulosFiltrados = new List<Articulo>();
            foreach (Articulo articulo in articulos)
            {
                if (articulo.StockTotal <= articulo.StockMinimo)
                {
                    articulosFiltrados.Add(articulo);
                }
            }
            return articulosFiltrados;
        }

        public void AgregaArticulo(Articulo articulo)
        {
            this.articulos.Add(articulo);
        }

        public List<Articulo> Articulos
        {
            get { return articulos; }
            set { articulos = value; }
        }


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }



        public String Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }


    }
}

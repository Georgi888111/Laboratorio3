using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal5
{
    class Conexion
    {
        protected SqlConnection con = null;

        public SqlConnection Conectar()
        {
            try
            {
                this.con = new SqlConnection("Data Source=DESKTOP-0S169QT;Initial Catalog=facturacion;Integrated Security=True");
                this.con.Open();
                return this.con;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }

        public void Desconectar()
        {
            try
            {
                this.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public List<Factura> llenaFacturas()
        {
            List<Factura> facturas = new List<Factura>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Factura", this.Conectar());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                facturas.Add(ConvertirFactura(reader));
            }

            this.Desconectar();

            return facturas;
        }
        private static Factura ConvertirFactura(SqlDataReader reader)
        {
            Factura factura = new Factura
            {
                Id = Convert.ToInt32(reader["Id"]),
                Fecha = Convert.ToString(reader["fecha"]),
            };

            return factura;
        }

        public List<Articulo> llenaArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Articulo", this.Conectar());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                articulos.Add(ConvertirArticulo(reader));
            }

            this.Desconectar();


            return articulos;
        }

        private static Articulo ConvertirArticulo(SqlDataReader reader)
        {
            Articulo articulo = new Articulo
            {
                Id = Convert.ToInt32((reader["Id"])),
                Nombre = Convert.ToString(reader["nombre"]),
                Precio = Convert.ToDouble(reader["precioArticulo"]),

            };

            return articulo;
        }
        public List<Detalle> llenaDetalles(int id)
        {
            List<Detalle> detalles = new List<Detalle>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Detalle WHERE idFactura=" + id, this.Conectar());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                detalles.Add(ConvertirDetalle(reader));
            }

            this.Desconectar();
            return detalles;
        }

        private static Detalle ConvertirDetalle(SqlDataReader reader)
        {
            Detalle detalle = new Detalle
            {
                Id = Convert.ToInt32(reader["Id"]),
                Cantidad = Convert.ToInt32(reader["cantidad"]),
                IdArticulo = Convert.ToInt32(reader["idArticulo"]),
                IdFactura = Convert.ToInt32(reader["idFactura"]),
            };

            return detalle;
        }

    }
}
    


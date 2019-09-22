using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WindowsFormsApplication1.clases
{
    public class GestorPersona
    {

        Conexion cx = new Conexion();
        MySqlCommand cmd = null;

        public DataTable mostrarDatos()
        {

            try
            {
                String qry = "SELECT * from Customers";
                cmd = new MySqlCommand(qry, cx.conectar());
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
            finally
            {
                cx.desconectar();
            }

        }

        public DataTable buscarDatosXID(String ID)
        {
            string qry = "SELECT * from Customers WHERE CustomerID=@ID";
            try
            {

                cmd = new MySqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@ID", ID);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                cx.desconectar();
            }

        }

        public DataTable buscarDatosXNombre(String nombre)
        {
            string qry = "SELECT * from Customers WHERE CompanyName LIKE @nombre";
            try
            {
                cmd = new MySqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@nombre", nombre + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                cx.desconectar();
            }


        }

        public void insertarDatos(Cliente cliente)
        {
            string qry = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)"
                                         + " VALUES (@id, @compania, @contacto,@titulo,@direccion,@ciudad,@region,@codpostal,@pais,@telefono,@fax)";
            try
            {
                cmd = new MySqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.Parameters.AddWithValue("@compania", cliente.Compania);
                cmd.Parameters.AddWithValue("@contacto", cliente.Contacto);
                cmd.Parameters.AddWithValue("@titulo", cliente.Titulo);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@ciudad", cliente.Ciudad);
                cmd.Parameters.AddWithValue("@region", cliente.Region);
                cmd.Parameters.AddWithValue("@codpostal", cliente.Codpostal);
                cmd.Parameters.AddWithValue("@pais", cliente.Pais);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@fax", cliente.Fax);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                cx.desconectar();
            }

        }

        public void actualizarDatos(Cliente cliente)
        {
            string qry = "UPDATE Customers SET CompanyName=@compania, ContactName=@contacto, ContactTitle=@titulo, Address=@direccion, City=@ciudad, Region=@region, PostalCode=@codpostal, Country=@pais, Phone=@telefono, Fax=@fax"
                                         + " WHERE CustomerID=@id";
            try
            {
                cmd = new MySqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@compania", cliente.Compania);
                cmd.Parameters.AddWithValue("@contacto", cliente.Contacto);
                cmd.Parameters.AddWithValue("@titulo", cliente.Titulo);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@ciudad", cliente.Ciudad);
                cmd.Parameters.AddWithValue("@region", cliente.Region);
                cmd.Parameters.AddWithValue("@codpostal", cliente.Codpostal);
                cmd.Parameters.AddWithValue("@pais", cliente.Pais);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@fax", cliente.Fax);
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                cx.desconectar();
            }

        }

        public void eliminarDatos(String ID)
        {
            string qry = "DELETE FROM Customers WHERE CustomerID=@id";
            try
            {
                cmd = new MySqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                cx.desconectar();
            }

        }


    }
}

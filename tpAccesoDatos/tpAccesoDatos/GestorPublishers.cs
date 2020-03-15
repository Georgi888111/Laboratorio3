using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpAccesoDatos
{
    class GestorPublishers
    {
        Conexion cx = new Conexion();
        SqlCommand cmd = null;

        public DataTable mostrarDatos()
        {

            try
            {
                String qry = "SELECT * from publishers";
                cmd = new SqlCommand(qry, cx.conectar());
                SqlDataAdapter da = new SqlDataAdapter();
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


        public void insertarDatos(Publishers publishers)
        {
            string qry = "INSERT INTO publishers (pub_id, pub_name, city, state, country)"
                                         + " VALUES (@pub_id, @pub_name, @city,@state,@country)";
            try
            {
                cmd = new SqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@pub_id", publishers.Id);
                cmd.Parameters.AddWithValue("@pub_name", publishers.Nombre);
                cmd.Parameters.AddWithValue("@city", publishers.Ciudad);
                cmd.Parameters.AddWithValue("@state", publishers.Estado);
                cmd.Parameters.AddWithValue("@country", publishers.Pais);
           
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
                MessageBox.Show("Aviso!", "No se ha podido agregar el publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cx.desconectar();
            }

        }

        public void actualizarDatos(Publishers publishers)
        {
            string qry = "UPDATE publishers SET pub_name=@pub_name, city=@city, state=@state, country=@country "
                                         + " WHERE pub_id=@pub_id";
            try
            {
                cmd = new SqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@pub_id", publishers.Id);
                cmd.Parameters.AddWithValue("@pub_name", publishers.Nombre);
                cmd.Parameters.AddWithValue("@city", publishers.Ciudad);
                cmd.Parameters.AddWithValue("@state", publishers.Estado);
                cmd.Parameters.AddWithValue("@country", publishers.Pais);
                
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
            
            string qry = "DELETE FROM publishers WHERE pub_id=" + ID;
            cmd = new SqlCommand(qry, cx.conectar());
            this.cmd.CommandType = CommandType.Text;
            try
            {

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
                MessageBox.Show("El campo que desea eliminar tiene una relacion con otra tabla, no es posible realizar la operacion");
            }
            finally
            {
                cx.desconectar();
            }

        }
    }
    }


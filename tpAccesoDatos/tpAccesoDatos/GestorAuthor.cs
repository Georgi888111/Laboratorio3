using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpAccesoDatos
{
    class GestorAuthor
    {

        Conexion cx = new Conexion();
        SqlCommand cmd = null;
        public void insertarDatos(Author author)
        {
            string qry = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract)"
                                         + " VALUES (@au_id, @au_lname, @au_fname,@phone,@address,@city,@state,@zip,@contract)";
            try
            {
                cmd = new SqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@au_id", author.Id);
                cmd.Parameters.AddWithValue("@au_lname", author.Apellido);
                cmd.Parameters.AddWithValue("@au_fname", author.Nombre);
                cmd.Parameters.AddWithValue("@phone", author.Telefono);
                cmd.Parameters.AddWithValue("@address", author.Direccion);
                cmd.Parameters.AddWithValue("@city", author.Ciudad);
                cmd.Parameters.AddWithValue("@state", author.Estado);
                cmd.Parameters.AddWithValue("@zip", author.CodPostal);
                cmd.Parameters.AddWithValue("@contract", author.Contrato);
               
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                MessageBox.Show("Aviso!", "Se agregó correctamente el author", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Aviso!", "No se ha podido agregar el author", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                cx.desconectar();
            }

        }
    }
}

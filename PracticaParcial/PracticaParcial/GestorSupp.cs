using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpAccesoDatos;

namespace PracticaParcial
{
    class GestorSupp
    {
        
        Conexion cx = new Conexion();
        SqlCommand cmd = null;



        public void insertarDatos(Suppliers suppliers)
        {
            string qry = "SET IDENTITY_INSERT Suppliers ON " + "INSERT INTO Suppliers (SupplierID, CompanyName, ContactName, ContactTitle, Address, City,Region, PostalCode,Country,Phone, Fax, HomePage)"
                                         + " VALUES (@SupplierID, @CompanyName, @ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Fax,@HomePage)";
            try
            {
                cmd = new SqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@SupplierID", suppliers.Id);
                cmd.Parameters.AddWithValue("@CompanyName", suppliers.CompanyName);
                cmd.Parameters.AddWithValue("@ContactName", suppliers.ContactName);
                cmd.Parameters.AddWithValue("@ContactTitle", suppliers.ContactTitle);
                cmd.Parameters.AddWithValue("@City", suppliers.City);
                cmd.Parameters.AddWithValue("@PostalCode", suppliers.CodPostal);
                cmd.Parameters.AddWithValue("@Country", suppliers.Country);
                cmd.Parameters.AddWithValue("@Phone", suppliers.Phone);
                cmd.Parameters.AddWithValue("@Fax", suppliers.Fax);
                cmd.Parameters.AddWithValue("@Address", suppliers.Address);
                cmd.Parameters.AddWithValue("@HomePage", suppliers.HomePage);
                cmd.Parameters.AddWithValue("@Region", suppliers.Region);

              

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.ToString(), ex);
                //MessageBox.Show("Aviso!", "No se ha podido agregar el suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cx.desconectar();
            }

        }

        public void modificarDatos(Suppliers suppliers)
        {
            string qry = "UPDATE Suppliers SET CompanyName=@CompanyName, ContactName=@ContactName, ContactTitle=@ContactTitle,Address=@Address, City=@City, Region=@Region, PostalCode=@PostalCode,Country=@Country,Phone=@Phone,Fax=@Fax,HomePage=@HomePage"
                                         + " WHERE SupplierID=@SupplierID";

          
            try
            {
                cmd = new SqlCommand(qry, cx.conectar());
                cmd.Parameters.AddWithValue("@SupplierID", suppliers.Id);
                cmd.Parameters.AddWithValue("@CompanyName", suppliers.CompanyName);
                cmd.Parameters.AddWithValue("@ContactName", suppliers.ContactName);
                cmd.Parameters.AddWithValue("@ContactTitle", suppliers.ContactTitle);
                cmd.Parameters.AddWithValue("@City", suppliers.City);
                cmd.Parameters.AddWithValue("@PostalCode", suppliers.CodPostal);
                cmd.Parameters.AddWithValue("@Country", suppliers.Country);
                cmd.Parameters.AddWithValue("@Phone", suppliers.Phone);
                cmd.Parameters.AddWithValue("@Fax", suppliers.Fax);
                cmd.Parameters.AddWithValue("@Address", suppliers.Address);
                cmd.Parameters.AddWithValue("@HomePage", suppliers.HomePage);
                cmd.Parameters.AddWithValue("@Region", suppliers.Region);

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

            string qry = "DELETE FROM Suppliers WHERE SupplierID=" + ID;
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
                MessageBox.Show("No es posible realizar la operacion");
            }
            finally
            {
                cx.desconectar();
            }

        }


    }

}

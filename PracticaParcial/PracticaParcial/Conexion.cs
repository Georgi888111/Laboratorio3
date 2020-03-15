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
    class Conexion
    {

        protected SqlConnection con = null;

        public SqlConnection conectar()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-0S169QT;Initial Catalog=Northwind;Integrated Security=True");
                con.Open();
                MessageBox.Show("Aviso!", "Conectado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso!", "No se ha podido conectar a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
                return null;
            }

        }

        public bool desconectar()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

        }

    }
}

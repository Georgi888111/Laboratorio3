using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1.clases
{
    class Conexion
    {
        protected SqlConnection con = null;

        public SqlConnection conectar()
        {
            try
            {   //Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True
                con = new SqlConnection("Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");
                con.Open();
                return con;
            }
            catch(Exception ex) {
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
                else {
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

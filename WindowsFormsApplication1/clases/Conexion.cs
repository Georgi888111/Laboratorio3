using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WindowsFormsApplication1.clases
{
    class Conexion
    {
        protected MySqlConnection con = null;

        public MySqlConnection conectar()
        {
            try
            {   //Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True
                con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=northwind");
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
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

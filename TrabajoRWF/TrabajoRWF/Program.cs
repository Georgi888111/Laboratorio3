using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;
using System.IO;

namespace TrabajoRWF
{
    class Program
    {
        static void Main(string[] args)
        {




            List<String> datosBase = new List<String>();
            escribirArchivo(datosBase);
            leerArchivo();



        }


        public static void escribirArchivo(List<string> lista)
        {
            String select = "select * from customers";

            MySqlCommand cmd = new MySqlCommand(select, connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            StreamWriter escribir = new StreamWriter(@"C:\Users\Georgi\source\repos\Customers.txt");

            while (reader.Read())
            {
                lista.Add(reader.GetString(0)+"\t");
                lista.Add(reader.GetString(1)+"\t");
                lista.Add(reader.GetString(2)+ "\t");
                lista.Add(reader.GetString(3)+ "\t");
                lista.Add(reader.GetString(4)+ "\t");
                lista.Add(reader.GetString(5)+ "\t");
                lista.Add(reader.GetString(6)+ "\t");
                lista.Add(reader.GetString(7)+ "\t");
                lista.Add(reader.GetString(8)+ "\t");
                lista.Add(reader.GetString(9)+ "\t");
                lista.Add(reader.GetString(10)+ "\n");
               




            }
            reader.Close();
            using (escribir)
            {
                foreach (String x in lista)
                {
                    escribir.Write(x);
                }
            }
        }
        public static void leerArchivo()
        {


           

            //MySqlCommand cmd = new MySqlCommand(select, connection());
            MySqlConnection conn = connection();
            
            String query = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) values (?CustomerID,?CompanyName,?ContactName,?ContactTitle,?Address,?City,?Region,?PostalCode,?Country,?Phone,?Fax) ON DUPLICATE KEY UPDATE CustomerID = ?CustomerID ";
            MySqlCommand comm = new MySqlCommand(query, conn);
            
            
                StreamReader leer = new StreamReader(@"C:\Users\Georgi\source\repos\Customers.txt");


                int increment = 0;
                while (!leer.EndOfStream)
                {
                    String linea = leer.ReadLine();
                    String[] array = linea.Split('\t');
                String incre = increment.ToString();
                comm.Parameters.Add("?CustomerID", MySqlDbType.VarChar).Value= array[0].Insert(4,incre);
                comm.Parameters.Add("?CompanyName", MySqlDbType.VarChar).Value = array[1];
                comm.Parameters.Add("?ContactName", MySqlDbType.VarChar).Value = array[2];
                comm.Parameters.Add("?ContactTitle", MySqlDbType.VarChar).Value = array[3];
                comm.Parameters.Add("?Address", MySqlDbType.VarChar).Value = array[4];
                comm.Parameters.Add("?City", MySqlDbType.VarChar).Value = array[5];
                comm.Parameters.Add("?Region", MySqlDbType.VarChar).Value = array[6];
                comm.Parameters.Add("?PostalCode", MySqlDbType.VarChar).Value = array[7];
                comm.Parameters.Add("?Country", MySqlDbType.VarChar).Value = array[8];
                comm.Parameters.Add("?Phone", MySqlDbType.VarChar).Value = array[9];
                comm.Parameters.Add("?Fax", MySqlDbType.VarChar).Value = array[10];
                comm.ExecuteNonQuery();
                comm.Parameters.Clear();
                increment++;
                }
            
            conn.Close();

        }

        public static MySqlConnection connection()
        {

            MySqlConnection conect = new MySqlConnection();
            string cadenaCon = "Server=localhost;Port=3306;Database=northwind;Uid=root;Pwd=;";

            try
            {
                conect.ConnectionString = cadenaCon;
                conect.Open();
                Console.WriteLine("La base se ha conectado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("La base no se ha conectado");
            }

            return conect;

            

        }
    }
}
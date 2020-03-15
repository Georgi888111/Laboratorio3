using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Parcial1Lab___Crespo
{
    class Program
    {
        static void Main(string[] args)
        {

            cargaMatriz();
            Thread hilo2 = new Thread(new ThreadStart(ejecutarHiloDiezSeg));



            hilo2.Start();
            cargaNumeros();
            leerBaseDatos();

        }

        public static MySqlConnection connection()
        {

            MySqlConnection conect = new MySqlConnection();
            string cadenaCon = "Server=localhost;Port=3306;Database=parcial1;Uid=root;Pwd=;";

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

        public static void leerBaseDatos()


        {


            String select = "select * from detalleremito";

            MySqlCommand cmd = new MySqlCommand(select, connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            List<JObject> detalles = new List<JObject>();

            while (reader.Read())
            {

                JObject detalle = new JObject(
                new JProperty("id", reader.GetString(0)),
                new JProperty("subtotal", reader.GetString(1)),
                new JProperty("cantidad", reader.GetString(2))



            );
                detalles.Add(detalle);



            }
            reader.Close();
            String select2 = "select * from articulo";

            MySqlCommand cmd2 = new MySqlCommand(select2, connection());
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            List<JObject> articulos = new List<JObject>();

            while (reader2.Read())
            {

                JObject articulo = new JObject(
                new JProperty("id", reader2.GetString(0)),
                new JProperty("nombre", reader2.GetString(1)),
                new JProperty("precio", reader2.GetString(2))




            );
                articulos.Add(articulo);



            }
            reader2.Close();

            String select3 = "select * from remitosalida";

            MySqlCommand cmd3 = new MySqlCommand(select3, connection());
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            List<JObject> remitos = new List<JObject>();

            while (reader3.Read())
            {

                JObject remito = new JObject(
                new JProperty("id", reader3.GetString(0)),
                new JProperty("fecha", reader3.GetString(1)),
                new JProperty("total", reader3.GetString(2))




            );
                remitos.Add(remito);



            }
            reader3.Close();

            using (StreamWriter file = File.CreateText(@"C:\Users\Georgi\source\repos\factura.txt"))
            {
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.Formatting = Formatting.Indented;

                    foreach (JObject remito in remitos)
                    {


                        remito.WriteTo(writer);
                        writer.WriteStartArray();


                        foreach (JObject detalle in detalles)
                        {


                            if (remito.GetValue("id").Equals(detalle.GetValue("id")))
                            {




                                detalle.WriteTo(writer);
                                writer.WriteStartArray();


                                foreach (JObject articulo in articulos)
                                {

                                    if (detalle.GetValue("id").Equals(articulo.GetValue("id")))
                                    {
                                        articulo.WriteTo(writer);
                                    }


                                }



                                writer.WriteEndArray();


                            }

                            writer.WriteEndArray();
                        }
                     
                    }

                }
            }
        }

                public static void cargaMatriz()
        {
          
                int num = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese un numero para crear una matriz, debe ser impar y mayor o igual a 3: ");
                    num = Int32.Parse(Console.ReadLine());
                        if ((num < 3) || (num % 2 == 0))
                        {
                            throw new FormatException();
                        }
                        int mitad = (num - 1) / 2;
                        int[,] matriz = new int[num, num];
                        for (int i = 0; i < num; i++)
                        {
                            for (int j = 0; j < num; j++)
                            {
                                if (i == mitad || j == mitad)
                                {
                                    matriz[i, j] = 1;
                                }
                                else
                                {
                                    matriz[i, j] = 0;
                                }
                            }
                        }
                        for (int i = 0; i < num; i++)
                        {
                            for (int j = 0; j < num; j++)
                            {
                                Console.Write(matriz[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("“El valor ingresado debe ser un numero entero y mayor o igual a 3");
                        continue;
                    }
                } while (num < 3 && num % 2 == 0);


            }

            public static void ejecutarHiloDiezSeg()
        {
            while (true)
            {
                Thread.Sleep(10000);
                Console.WriteLine("Hilo ejecutado");

            }
        }

        public static void cargaNumeros()
        {

            Console.WriteLine("Ingrese numeros, cuando desee terminar ingrese 0");

            List<int> numeros = new List<int>();
            int numero = 0;

            do
            {
                try
                {
                    Console.WriteLine("Ingrese un número");


                    numero = Int32.Parse(Console.ReadLine());
                    if (numero != 0)
                    {

                        numeros.Add(numero);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar sólo numeros");
                }

            } while (numero != 0);
            List<String> numerosParseados = new List<string>();
            foreach (int n in numeros)
            {
                string num = n.ToString();
                numerosParseados.Add(num);
            }



            StreamWriter escribir = new StreamWriter(@"C:\Users\Georgi\source\repos\numeros.txt");

            using (escribir)
            {
                foreach (string n in numerosParseados)
                {
                    escribir.Write(n + "-");
                }
            }


            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            StreamReader leer = new StreamReader(@"C:\Users\Georgi\source\repos\numeros.txt");
            String[] linea = leer.ReadLine().Split('-');

            foreach (string numTxt in linea)
            {
               
                int numPars = 0;
                try
                {
                    numPars = Int32.Parse(numTxt);
                }
                catch (FormatException e)
                {
                    Console.WriteLine();
                }
                if (numPars % 2 == 0)
                {
                    pares.Add(numPars);
                }
                else
                {
                    impares.Add(numPars);
                }

            }

            Console.Write("Pares: ");
            foreach (int impar in pares)
            {
                Console.Write(impar + ",");
            }
            Console.WriteLine();
            Console.Write("Impares: ");
            foreach (int par in impares)
            {
                Console.Write(par + ",");
            }
        }
    }
}

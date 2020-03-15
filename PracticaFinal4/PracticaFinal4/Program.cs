using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace PracticaFinal4
{
    class Program
    {
       
        static void Main(string[] args)
        {

            //crearMatriz();
            //Thread hilo1;
            //hilo1 = new Thread(new ThreadStart(ejecutarHilo));
            //hilo1.Start();
            //Empleado empleado = new Empleado();
            //empleado.Apellido = "Gonzales";
            //empleado.Nombre = "Gonzalo";
            //empleado.Cuit = 2323;
            //Empleado empleado1 = new Empleado();
            //empleado.Apellido = "Sepulveda";
            //empleado.Nombre = "Cristian";
            //empleado.Cuit = 2323;
            //Empleado empleado2 = new Empleado();
            //empleado.Apellido = "Martinez";
            //empleado.Nombre = "Martin";
            //empleado.Cuit = 2555;



            //Sector sector = new Sector();
            //sector.Empleados.Add(empleado);
            //sector.Empleados.Add(empleado1);
            //sector.Empleados.Add(empleado2);
            //sector.verificarCUITEmpleados();

            //writeFile();
            //readFile();
            llenaxml();


        }
        public static void crearMatriz()
        {
            int numero = 0;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese un número entero impar mayor o igual a tres");
                    numero = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("El número debe ser entero, el formato es incorrecto");
                }
            } while (numero < 3 || numero % 2 == 0);

            int[,] matriz = new int[numero, numero];
            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        matriz[i, j] = 1;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ejecutarHilo()
        {
            while (true)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Hilo ejecutado 5");

            }
        }

        public static void writeFile()
        {
            using (StreamWriter escribir = new StreamWriter(@"C:\Users\Georgi\source\repos\practica.txt"))
            {
                String datos = "Carlos,Lopez,29118614,Salta#Jose,Sanchez,11045855,Cordoba#Luis,Perez,08654789,Misiones#Alberto,Tobares,15654258,Mendoza";
                escribir.WriteLine(datos);

            }
        }

        public static void readFile()
        {
            StreamReader leer = new StreamReader(@"C:\Users\Georgi\source\repos\practica.txt");
            while (!leer.EndOfStream)
            {
                string[] linea = leer.ReadLine().Split('#');
                foreach (string l in linea)
                {
                    string[] campo = l.Split(',');
                    Console.Write(campo[0] + "    " + campo[1] + "    " + campo[2] + '\n');
                }


            }
        }

        public static void llenaxml()
        {
        List<Factura> facturas = new List<Factura>();
        List<Articulo> articulos = new List<Articulo>();
        Conexion conexion = new Conexion();
        facturas = conexion.llenaFacturas();
            articulos = conexion.llenaArticulos();
            foreach (Factura fa in facturas)
            {
                List<Detalle> detalles = conexion.llenaDetalles(fa.Id);
                foreach (Detalle detalle in detalles)
                {
                    foreach (Articulo articulo in articulos)
                    {
                        if (detalle.IdArticulo == articulo.Id)
                        {
                            detalle.Articulos.Add(articulo);
                        }
                    }
                }

                fa.Detalles = detalles;
            }
             
            string ruta = @"C:\Users\Georgi\source\repos\archivo.xml";
            XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Facturas");
            foreach (Factura factura in facturas)
            {
                writer.WriteStartElement("Factura");
                writer.WriteElementString("ID", factura.Id.ToString());
                writer.WriteElementString("Fecha", factura.Fecha.ToString());
                writer.WriteElementString("Total", factura.Total.ToString());
                writer.WriteStartElement("Detalles");

                foreach (Detalle detalle in factura.Detalles)
                {
                    writer.WriteElementString("ID", detalle.Id.ToString());
                    writer.WriteElementString("Subtotal", detalle.Subtotal.ToString());
                    writer.WriteElementString("Cantidad", detalle.Cantidad.ToString());
                    foreach (Articulo articulo in detalle.Articulos)
                    {
                        writer.WriteStartElement("Articulo");
                        writer.WriteElementString("ID", articulo.Id.ToString());
                        writer.WriteElementString("Nombre", articulo.Nombre);
                        writer.WriteElementString("Precio", articulo.Precio.ToString());
                        writer.WriteEndElement();
                    }

                }
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

}
    }




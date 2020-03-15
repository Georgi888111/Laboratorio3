using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int[,] matriz;
            do
            {
                try
                {


                    Console.WriteLine("Ingrese un numero impar mayor o igual a 3");
                    numero = Int32.Parse(Console.ReadLine());
                    if (!(numero % 2 == 0) && (numero >= 3))
                    {
                        matriz = new int[numero, numero];
                        for (int i = 0; i < numero; i++)
                        {
                            for (int j = 0; j < numero; j++)
                            {
                                if (i + j == numero - 1)
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
                        break;
                    }

                    else
                    {
                        throw new FormatException();
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("El número debe ser impar y mayor o igual a 3");
                }
            } while (!(numero % 2 == 0) || (numero >= 3));


            Thread hilo1 = new Thread(new ThreadStart(ejecutarHiloCincoSeg));
            //Thread hilo2 = new Thread(new ThreadStart(ejecutarHiloDiezSeg));


            //hilo1.Start();

            //  hilo2.Start();


            //hilo1.Join();

            //  hilo2.Join();
            ejercicio3();

            String datos = "Carlos, Lopez,29118614,Salta#Jose,Sanchez,11045855,Cordoba#Luis,Perez,08654789,Misiones#Alberto,Tobares,15654258,Mendoza";

            StreamWriter escribir = new StreamWriter(@"C:\Users\Georgi\source\repos\Parcial.txt");
            using (escribir)
            {
                escribir.Write(datos);
            }

            StreamReader leer = new StreamReader(@"C:\Users\Georgi\source\repos\Parcial.txt");



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

        public static void ejecutarHiloCincoSeg()
        {
            while (true)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Hilo ejecutado 5");

            }
        }

        public static void ejecutarHiloDiezSeg()
        {
            while (true)
            {
                Thread.Sleep(10000);
                Console.WriteLine("Hilo ejecutado 10");

            }
        }

        public static void ejercicio3()
        {
            Sector s = new Sector();
            Empleado e1 = new Empleado();
            e1.Cuit = 1;

            Empleado e2 = new Empleado();
            e2.Cuit = 2;
            Empleado e3 = new Empleado();
            e3.Cuit = 2;
            Empleado e4 = new Empleado();
            e4.Cuit = 4;
            s.Empleados.Add(e1);
            s.Empleados.Add(e2);
            s.Empleados.Add(e3);
            s.Empleados.Add(e4);
            s.verificarCuitEmpleado();
        }
    }
}

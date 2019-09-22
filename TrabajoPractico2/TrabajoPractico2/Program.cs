using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TrabajoPractico2
{
    class Program
    {
        static void Main(string[] args)

        {
            //B1
            int numera = 0, denom = 0;
            Fraccion fraccion = new Fraccion();

            Fraccion fraccion2 = new Fraccion();




            Console.WriteLine("Ingrese dos fracciones para operar");
            Console.WriteLine("Fraccion uno");
            do
            {
                try
                {

                    Console.WriteLine("Ingrese el numerador");
                    numera = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el denominador");
                    denom = Int32.Parse(Console.ReadLine());
                    fraccion.validaNumeraYdenomina(numera, denom);
                    break;


                }
                catch (FraccionException fe)
                {
                    Console.WriteLine(fe.Message);
                }

            } while (true);

            fraccion.Numerador = numera;
            fraccion.Denominador = denom;

            Console.WriteLine("Fraccion dos");
            numera = 0;
            denom = 0;

            do
            {
                try
                {
                    Console.WriteLine("Ingrese el numerador");
                    numera = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el denominador");
                    denom = Int32.Parse(Console.ReadLine());
                    fraccion2.validaNumeraYdenomina(numera, denom);
                    break;
                }
                catch (FraccionException fe)
                {
                    Console.WriteLine(fe.Message);
                }

            } while (true);

            fraccion2.Numerador = numera;
            fraccion2.Denominador = denom;


            int opcion;
            do
            {
                do
                {
                    Console.WriteLine("Qué operación quiere realizar?, ingrese 0 para salir");
                    Console.WriteLine("1-SUMA");
                    Console.WriteLine("2-RESTA");
                    Console.WriteLine("3-MULTIPLICACION");
                    Console.WriteLine("4-DIVISION");


                    opcion = Int32.Parse(Console.ReadLine());
                } while (validaOperacionIngre(opcion) == false);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado de la suma es: " + fraccion.suma(fraccion, fraccion2).Numerador + "/" + fraccion.suma(fraccion, fraccion2).Denominador);

                        break;
                    case 2:
                        Console.WriteLine("El resultado de la resta es: " + fraccion.resta(fraccion, fraccion2).Numerador + "/" + fraccion.resta(fraccion, fraccion2).Denominador);

                        break;
                    case 3:
                        Console.WriteLine("El resultado de la multiplicacion es: " + fraccion.multiplicacion(fraccion, fraccion2).Numerador + "/" + fraccion.multiplicacion(fraccion, fraccion2).Denominador);

                        break;
                    case 4:

                        Console.WriteLine("El resultado de la division es: " + fraccion.division(fraccion, fraccion2).Numerador + "/" + fraccion.division(fraccion, fraccion2).Denominador);
                        break;






                }
            } while (opcion !=0);




            //B2
            String frase, frase2;
            Console.WriteLine("Ingrese una frase corta.");
            frase = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese otra frase igual o mas corta que la anterior");
                frase2 = Console.ReadLine();
            } while (ValidaLargo(frase, frase2) == true);

            if (frase.Contains(frase2))
            {
                Console.WriteLine("Encontrado");
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
            //C1
                Console.WriteLine("Ingrese la cantidad de filas");
            int filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas");
            int columnas = Int32.Parse(Console.ReadLine());
            String[,] matriz = new String[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (((i + 1) + (j + 1)) == (filas + columnas))
                    {
                        matriz[i, j] = "x";
                    }
                    else
                    {
                        matriz[i, j] = "0";
                    }
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "-");
                }
                Console.WriteLine("");
            }
            //C2
            Console.WriteLine("Ingrese varios numeros separados por coma");
            String numerosCadena = Console.ReadLine();
            String[] numeros = numerosCadena.Split(',');
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma = suma + Int32.Parse(numeros[i]);
            }

            Console.WriteLine("El resultado de la suma es: " + suma);

            //D5
            String nro;
            Cheque cheque = new Cheque();
            cheque.Banco = "La Nacion";
            cheque.Numero = 123123;
            cheque.Propietario = "Georgina Crespo";
            cheque.Importe = 12.300;
            do
            {
                Console.WriteLine("Ingrese el nro de interno");
                nro = Console.ReadLine();

            } while (!cheque.Guardar(nro));

            cheque.imprimir();

            //D6
            Articulo art = new Articulo();
            art.Codigo = "1234D";
            art.StockMinimo = 5;
            art.StockTotal = 10;
            Articulo art1 = new Articulo();
            art1.Codigo = "4567T";
            art1.StockMinimo = 4;
            art1.StockTotal = 4;
            Articulo art2 = new Articulo();
            art2.Codigo = "445788";
            art2.StockMinimo = 10;
            art2.StockTotal = 4;
            Deposito deposito = new Deposito();
            deposito.Nombre = "Honduras";
            deposito.Domicilio = "San Martin 12344";
            deposito.AgregaArticulo(art);
            deposito.AgregaArticulo(art1);
            deposito.AgregaArticulo(art2);
            art.Deposito = deposito;
            List<Articulo> articu = new List<Articulo>();
            articu = deposito.articulosBajoStock();
            foreach (var articulo in articu)
            {
                Console.WriteLine(articulo.Codigo);


            }

            //D7
            Circulo circulo = new Circulo();
            Triangulo triangulo = new Triangulo();
            Rectangulo rectangulo = new Rectangulo();
            List<Figura> figuras = new List<Figura>();
            figuras.Add(circulo);
            figuras.Add(triangulo);
            figuras.Add(rectangulo);
            foreach (Figura fig in figuras)
            {
                fig.Dibujar();

            }

            //E

            Thread hilo1 = new Thread(new ThreadStart(ejecutarHiloCincoSeg));
            Thread hilo2 = new Thread(new ThreadStart(ejecutarHiloDiezSeg));


            hilo1.Start();

            hilo2.Start();


            hilo1.Join();

            hilo2.Join();



        }






        public static bool validaOperacionIngre(int numero)
        {
            bool valida = false;
            if (numero >= 0 && numero <= 4)
            {
                valida = true;

            }
            else
            {
                Console.WriteLine("La opcion ingresada no es válida");
                valida = false;
            }
            return valida;
        }

        public static void ejecutarHiloCincoSeg()
        {
            while (true) {
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


        public static Boolean ValidaLargo(String frase1, String frase2)
        {
            Boolean valida=false;
            if (frase1.Length < frase2.Length)
            {
                valida= true;
                Console.WriteLine("La frase dos no tiene que ser mas larga que la frase uno");
            }
            else
            {
                valida= false;
                
            }
            return valida;
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto 1
            //Tipos de valor
            //Las variables de tipos de valor contienen sus datos directamente.Cada una de ellas tiene su propia copia de los datos, 
            //por lo que las operaciones efectuadas sobre una variable no pueden afectar a otra.
            //Ejemplos byte, short corto = 555, int a = 7, long b = 234234234 , char caracter = 'A',double precio = 1.2, float f =3.5f, bool estado = true, decimal numero = 9.33m
            //Tipos de referencia
            //Las variables de tipos de referencia contienen referencias a sus datos. Los datos para estas variables se almacenan en un objeto. 
            //Es posible que dos variables de tipos de referencia apunten al mismo objeto, por lo que las operaciones efectuadas sobre una variable pueden afectar al objeto apuntado por otra variable de referencia.
            //Ejemplos object, string, dynamic
            //Punto 2

            //Punto 3
            //int objetoCuenta = 96;
            //int prefijoValor = --objetoCuenta;
            //int sufijoValor = --objetoCuenta;
            //objetoCuenta -= prefijoValor++ + sufijoValor++;
            //Console.WriteLine("Objeto cuenta: " + objetoCuenta);
            //Console.WriteLine("Prefijo valor: " + prefijoValor);
            //Console.WriteLine("Sufijo valor: " + sufijoValor);
            //Los valores son: Objeto cuenta: -95
            //Prefijo valor: 96
            //Sufijo valor: 95

            //Punto 4
            //ordenaArrays();
            //punto 5
            //ordenaNumeros();
            //punto 6
            //    try
            //    {
            //        Console.WriteLine("Ingrese un numero entero para dividir");
            //        int numero = Int32.Parse(Console.ReadLine());
            //        divisionRecursiva(numero);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("El numero debe ser entero, y no debe ingresar letras");
            //    }

            //punto 7
            //creaMatriz();
            //punto 9
            //levantaCalculadora();
            //punto 10
            //levantaAbm();
            //punto 11
            //parcial 2, punto 3
            try
             {
                   Console.WriteLine("Ingrese un numero entero para realizar la potencia");
                   int numero = Int32.Parse(Console.ReadLine());
                   Console.WriteLine("Ingrese la potencia");
                   int potencia = Int32.Parse(Console.ReadLine());
                   recursionPotencia(numero, potencia);
            }
                catch (FormatException)
                {
                   Console.WriteLine("El numero debe ser entero, y no debe ingresar letras");
                }







            }

        //Parcial 2, punto 3
            public static void recursionPotencia(int numero, int potencia)
        {
            double resultado = Math.Pow(numero,potencia);
            if (resultado < 1000000)
            {
                recursionPotencia(resultado, numero);
            }
        }
        //punto 10
        public static void levantaAbm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Abm());
        }
        //punto 9

            public static void levantaCalculadora()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculadora());
        }
        //Punto 4
        public static void ordenaArrays()
        {
            int incre = 0;
            int[] pares = { 2, 4, 6, 8, 10 };
            int[] impares = { 1, 3, 5, 7, 9 };
            int[] ordenada = new int[10];
            try
            {
                for (int i = 0; i < ordenada.Length; i++)
                {
                    if (i <= 4)
                    {
                        ordenada[i] = pares[i];
                    }
                    else
                    {
                        ordenada[i] = impares[incre];
                        incre++;
                    }

                }
                Array.Sort(ordenada);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ocurrió un error, indice fuera de rango");
            }
            for (int i = 0; i < ordenada.Length; i++)
            {

                Console.WriteLine(ordenada[i]);
            }



        }
        //punto 5
        public static void ordenaNumeros()
        {
            Console.WriteLine("Ingrese numeros, cuando desee terminar ingrese x");
           
            List<int> numeros = new List<int>();
            String numero="";

            do
            {
                try
                {
                    Console.WriteLine("Ingrese un número");
                   
                 
                    numero = Console.ReadLine();
                    if (!numero.Equals("x"))
                    {
                        int numeroParseado = Int32.Parse(numero);
                        numeros.Add(numeroParseado);
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

            } while (!numero.Equals("x")) ;
            Console.WriteLine("Los números ordenados de manera ascendente");
            numeros.Sort();
            foreach(int num in numeros) { 
             Console.Write(num + "-");  
            }
            Console.WriteLine("Los números ordenados de manera descendente");
            numeros.Reverse();
            foreach (int num in numeros)
            {
                Console.Write(num + "-");
            }
        }
        //Punto 6
        public static void divisionRecursiva(int numero)
        {
            try
            {
                int division;
                division = numero / 2;
                Console.WriteLine("Resultado de la division: " + division);
                if (division > 1)
                {
                    divisionRecursiva(division);
                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }

        }
        //punto 7

        public static void creaMatriz()
        {
            try {
                Console.WriteLine("Ingrese un numero entero para crear una matriz");
                int numero = Int32.Parse(Console.ReadLine());
                int[,] matriz = new int[numero, numero];
                for (int i = 0; i < numero; i++)
                {
                    for (int j = 0; j < numero; j++)
                    {
                        if (i == j || i + j + 1 == matriz.GetLength(0))
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
                        Console.Write(matriz[i, j] + "-");

                    }
                    Console.WriteLine("");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ocurrió un error indice fuera de rango");
            }
            }
    }
}

        
        
                
            
        
     

    


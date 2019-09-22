using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            //Punto 1
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }


            int j = 1;
            while (j < 101)
            {
                if ((j % 2 == 0) && (j % 5 == 0))
                {
                    Console.WriteLine(j);
                }

                j++;

            }

            int a = 1;
            do
            {
                if ((a % 2 == 0) && (a % 5 == 0))
                {
                    Console.WriteLine(a);
                }

                a++;
            } while (a < 101);

            //punto 2
            Random rnd = new Random();
            int numRandom = rnd.Next(1, 101);
            int cont = 0;
            Boolean encontrado = false;

            do
            {
                Console.WriteLine("Ingrese un numero entre 1 y 100");
                int numIngresado = Int32.Parse(Console.ReadLine());

                if (numIngresado < numRandom)
                {
                    Console.WriteLine("Es muy bajo");
                    cont++;
                }
                else if (numIngresado > numRandom)
                {
                    Console.WriteLine("Es muy alto");
                    cont++;
                }
                else
                {
                    Console.WriteLine("Correcto! numero encontrado, cantidad de intetos " + cont);
                    encontrado = true;
                }
            } while (encontrado == false);

            //punto 3

            Console.WriteLine("Ingrese un número");
            int numero = Int32.Parse(Console.ReadLine());
            if (esPar(numero))
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

            //punto 4

            Console.WriteLine("Ingrese dos numeros para operar");
            Console.WriteLine("Ingrese el primer número");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            int num2 = Int32.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Qué operación quiere realizar?");
                Console.WriteLine("1-SUMA");
                Console.WriteLine("2-RESTA");
                Console.WriteLine("3-DIVISION");
                Console.WriteLine("4-MULTIPLICACION");
                Console.WriteLine("5-MODULO");

                opcion = Int32.Parse(Console.ReadLine());
            } while (validaOperacionIngre(opcion) == false);
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El resultado de la suma es: " + suma(num1, num2));

                    break;
                case 2:
                    Console.WriteLine("El resultado de la resta es: " + resta(num1, num2));

                    break;
                case 3:
                    Console.WriteLine("El resultado de la resta es: " + multiplicacion(num1, num2));

                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero, ingrese nuevamente los valores");
                    }
                    else
                    {
                        Console.WriteLine("El resultado de la resta es: " + division(num1, num2));


                    }
                    break;
                case 5:
                    Console.WriteLine("El resultado de la resta es: " + modulo(num1, num2));

                    break;


            }

            //punto 5
            CargaDatos(0, 0);
            Console.ReadKey();

            //Punto 6
            int numeroRecur;
            do
            {
                Console.WriteLine("Ingrese un número");
                numeroRecur = Int32.Parse(Console.ReadLine());
            } while (numeroRecur <= 1);
            recur(numeroRecur);


            //Punto 7
            String cadena = "Mi nombre es Georgina Crespo";
            Console.WriteLine(cadena.Length);//El método Lenght muestra el largo de una cadena, contando los espacios en blanco.
            if (cadena.Contains("nombre")) //Contains sirve para saber si una cadena contiene otra. Es sensible a mayus y minus
            {
                Console.WriteLine("La cadena contiene la palabra nombre");
            }
            else
            {
                Console.WriteLine("No contiene la palabra nombre");
            }

            Console.WriteLine(cadena.IndexOf('G'));//Te muestra el indice o posicion de ese caracter.
            Console.WriteLine(cadena.Remove(5));//Remueve todo lo que sigue despues de esa posicion.
            Console.WriteLine(cadena.Replace('o', 'i'));//Reemplaza el caracter que se pide en 1er parametro por el 2do.
            Console.WriteLine(cadena.Substring(4, 8));//Muestra una subcadena tomando como referencia los indices que se le pasan como parametro de principio y de fin
            Console.WriteLine(cadena.ToUpper());//Muestra la cadena en mayuscula
            Console.WriteLine(cadena.ToLower());//Muestra la cadena en minuscula
            StringBuilder sb = new StringBuilder("Cadena ");
            sb.Append(cadena);
            Console.WriteLine(sb);//Append  - Retorna una nueva cadena, anexando cadena2 a cadena1, al final de la misma

        }



        //punto 3

        static bool esPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        //punto 4
        static double suma(double num1, double num2)
        {

            return num1 + num2;
        }

        static double resta(double num1, double num2)
        {
            return num1 - num2;
        }

        static double multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        static double division(double num1, double num2)
        {

            return num1 / num2;

        }

        static double modulo(double num1, double num2)
        {
            return num1 % num2;
        }

        static bool validaOperacionIngre(int numero)
        {
            bool valida = false;
            if (numero >= 1 && numero <= 5)
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
        static void recur(long numero)

        {

            long resultado = numero * numero;
            if (resultado > 100000000)
            {

                Console.WriteLine(numero + "*" + numero + "=" + resultado);
                return;
            }
            else
            {
                Console.WriteLine(numero + "*" + numero + "=" + resultado);
                recur(resultado);
            }


        }
        //punto 5
        static float hsAMin(float a)
        {
            float pasadas;

            pasadas = a * 60;

            return pasadas;
        }

        public static String minAHora(float tiempo)
        {
            float minuto = tiempo % 60;
            float hora = (tiempo - (tiempo % 60)) / 60;

            String tiempofinal = (Math.Round(hora)) + "hs y " + (Math.Round(minuto)) + " minutos";

            return tiempofinal;
        }

        public static float tDiurno(float tiempo)
        {
            float pago = (tiempo / 60) * 10;
            return pago;
        }

        public static float tNocturno(float tiempo)
        {
            float pago = (tiempo / 60) * 15;
            return pago;
        }

        public static float turnoDiurno(float ingreso, float egreso)
        {
            float tiempotrabajado;
            float pago = 0;
            if (egreso < ingreso)
            {
                tiempotrabajado = (1440 - ingreso) + egreso;

                if (tiempotrabajado > 480)
                {
                    Console.WriteLine("El horario ingresado supera las 8 horas, por favor vuelva a ingresar los datos");
                    CargaDatos(pago, pago);
                }
            }
            else
            {
                tiempotrabajado = egreso - ingreso;
                pago = tDiurno(tiempotrabajado);
                Console.WriteLine("El empleado trabajó " + minAHora(tiempotrabajado) + ". Su pago es de $ " + pago);

            }

            return pago;
        }

        public static float turnoNocturno(float ingreso, float egreso)
        {
            float tiempotrabajado;
            float pago = 0;
            if (egreso < ingreso)
            {
                tiempotrabajado = (1440 - ingreso) + egreso;
                pago = tNocturno(tiempotrabajado);
                if (tiempotrabajado > 480)
                {
                    Console.WriteLine("El horario ingresado supera las 8 horas, por favor vuelva a ingresar los datos");
                    CargaDatos(pago, pago);
                }
                else
                {
                    Console.WriteLine("El empleado trabajó " + minAHora(tiempotrabajado) + ". Su pago es de $ " + pago);
                }
            }
            else
            {
                tiempotrabajado = egreso - ingreso;
                pago = tNocturno(tiempotrabajado);
                if (tiempotrabajado > 480)
                {
                    Console.WriteLine("El horario ingresado supera las 8 horas, por favor vuelva a ingresar los datos");
                    CargaDatos(pago, pago);
                }
                else
                {
                    Console.WriteLine("El empleado trabajó " + minAHora(tiempotrabajado) + ". Su pago es de $ " + pago);
                }
            }
            return pago;
        }

        public static float CargaDatos(float diurno, float nocturno)
        {

            float hEntrada, mEntrada, hSalida, mSalida, ingreso, egreso;
            float pago = 0;
            while (true)
            {
                Console.WriteLine("Ingrese hora de entrada entre las 0 y las 23 : ");
                hEntrada = float.Parse(Console.ReadLine());
                if (hEntrada < 24 && hEntrada >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cantidad de horas cargadas incorrecta, intentelo nuevamente.");
                }
            }
            while (true)
            {
                Console.WriteLine("Ingrese minutos de entrada entre 0 y 59: ");
                mEntrada = float.Parse(Console.ReadLine());
                if (mEntrada < 60)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cantidad de minutos cargados incorrecto, intentelo nuevamente.");
                }
            }
            while (true)
            {
                Console.WriteLine("Ingrese hora de salida: ");
                hSalida = float.Parse(Console.ReadLine());
                if (hSalida < 24 && hSalida >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cantidad de horas cargadas incorrecta, intentelo nuevamente.");
                }
            }
            while (true)
            {
                Console.WriteLine("Ingrese minutos de salida: ");
                mSalida = float.Parse(Console.ReadLine());
                if (mSalida < 60)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cantidad de minutos cargados incorrecto, intentelo nuevamente.");
                }

            }
            ingreso = (hsAMin(hEntrada) + mEntrada);
            egreso = (hsAMin(hSalida) + mSalida);

            if (hEntrada >= 8 && hEntrada < 20)
            {

                pago = turnoDiurno(ingreso, egreso);

            }
            else if ((hEntrada >= 20 && hSalida <= 8) || (hEntrada < 8 && hSalida < 8) || (hEntrada >= 20 && hSalida <= 23))
            {
                pago = turnoNocturno(ingreso, egreso);
            }
            else
            {
                Console.WriteLine("El horario cargado es erroneo, verifique que los horarios de entrada y salida correspondan al turno diurno o nocturno");
                CargaDatos(diurno, nocturno);
            }

            return pago;
        }




    }
}


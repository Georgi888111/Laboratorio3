using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalDiciembre
{
    public class Programa
    {
        static void Main()
        {

            IList<Estudiante> estudiantes = new List<Estudiante>() {
 new Estudiante() { Id = 1, Nombre = "Juan", Edad = 19 } ,
 new Estudiante() { Id = 2, Nombre = "Pedro", Edad = 21 } ,
 new Estudiante() { Id = 3, Nombre = "Jose", Edad = 25 } ,
 new Estudiante() { Id = 4, Nombre = "Carlos" , Edad = 20 } ,
 new Estudiante() { Id = 5, Nombre = "David" , Edad = 23 }
 };

            IEnumerable<Estudiante> estudiantes2 = new List<Estudiante>();
            estudiantes2 = from est in estudiantes where est.Edad >= 18 && est.Edad <= 22 select est;
            foreach (Estudiante estu in estudiantes2)
            {
                {
                    Console.WriteLine("Edad" + estu.Edad);
                    Console.WriteLine("Nombre" + estu.Nombre);
                }


                IEnumerable<Estudiante> estudiantes3 = new List<Estudiante>();
                estudiantes3 = from est in estudiantes where est.Nombre.Contains("j") select est;
                foreach (Estudiante estudiante in estudiantes3)
                {
                    Console.WriteLine("Edad" + estu.Edad);
                    Console.WriteLine("Nombre" + estu.Nombre);
                }

            }

        }
    }
}
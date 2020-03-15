using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaFinal8
{
    public class Alumno
    {
        private int dni;
        private String nombre;
        private int año;
        private Curso curso = new Curso();

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }
        public Curso Curso { get => curso; set => curso = value; }
    }
}

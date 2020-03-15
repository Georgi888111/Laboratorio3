using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaFinal6
{
 
    public class Profesor
    {
        private int dni;
        private String nombre;
        private String materia;
        private Curso curso = new Curso();

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Materia { get => materia; set => materia = value; }
        public Curso Curso { get => curso; set => curso = value; }
    }
}
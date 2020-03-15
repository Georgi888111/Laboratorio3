using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaFinal6
{
    public class Curso
    {
        private int id;
        private String division;
        private int horas;
        private List<Alumno> alumnos;
        private Profesor profesor;

        public int Id { get => id; set => id = value; }
        public string Division { get => division; set => division = value; }
        public int Horas { get => horas; set => horas = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }
    }
}
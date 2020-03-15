using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    class Alumno
    {
        private String nombre;
        private List<Nota>notas = new List<Nota>();

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Nota> Notas { get => notas; set => notas = value; }

        public double getMaximaNota()
        {
            double notaMayor = 0;
         foreach(Nota nota in Notas)
            {
                if (nota.Valor > notaMayor)
                {
                    notaMayor = nota.Valor;
                }
            }
            return notaMayor;
        }

        public double promedioNotas()
        {
            double suma = 0, promedio=0;
            foreach(Nota nota in notas)
            {
                suma = suma + nota.Valor;
            }
            promedio = suma / notas.Count();
            return promedio;
        }

    }
}

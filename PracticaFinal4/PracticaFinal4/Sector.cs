using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal4
{
    class Sector
    {
        private int codigo;
        private String denominacion;
        private int telefono;
        private List<Empleado> empleados = new List<Empleado>();

        public int Codigo { get => codigo; set => codigo = value; }
        public string Denominacion { get => denominacion; set => denominacion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        internal List<Empleado> Empleados { get => empleados; set => empleados = value; }

        public void verificarCUITEmpleados()
        {
            Boolean repetido = false;
            foreach (Empleado emple in Empleados)
            {

                if (buscaConcordancia(emple.Cuit))
                {
                    Console.WriteLine("Cuit repetido de: " + emple.Apellido + emple.Nombre);
                    repetido = true;
                    break;
                }
            }
            if (repetido == false)
            {
                Console.WriteLine("Empleados cargados correctamente");

            }
           
        }

        public bool buscaConcordancia(long cuit)
        {
            int contador=0;
            foreach(Empleado emple in Empleados)
            {
                if(emple.Cuit == cuit)
                {
                    contador++;
                }
            }
            if (contador > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

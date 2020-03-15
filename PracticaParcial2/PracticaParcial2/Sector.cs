using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    class Sector
    {
        private int id;
        private int codigo;
        private string denominacion;
        private int telefono;
        private List<Empleado> empleados = new List<Empleado>();

        public int Id { get => id; set => id = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Denominacion { get => denominacion; set => denominacion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Empleado> Empleados { get => empleados; set => empleados = value; }

        public void verificarCuitEmpleado()
        {
            bool verif = false;
            foreach(Empleado e in Empleados)
            {

                if (busqueda(e.Cuit))
                {
                    Console.WriteLine("Empleado repetido:");
                    verif = true;
                    break;

                }
              
            }
            if (verif == false)
            {
                Console.WriteLine("Empleado no repetido ");
            }

            
        }
        public bool busqueda(long cuit)
        {
            int contador=0;
            bool repite=false;
            foreach(Empleado e in Empleados)
            {
                if (e.Cuit == cuit)
                {
                    contador++;
                }
                if(contador > 1)
                {
                  
                    repite= true;
                }
                else
                {
                    repite= false;
                }
               
            }
            return repite;
        }
    }
}

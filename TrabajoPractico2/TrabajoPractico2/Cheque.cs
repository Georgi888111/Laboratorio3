using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Cheque
    {
        
        private String banco;
        private String propietario;
        private int numero;
        private double importe;
        private int nroInterno;

   

        public String Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        public String Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public Boolean ValidarNroInterno(String numero)
        {
          
            try
            {
             int numeroPrueba= int.Parse(numero);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("No es un entero");
                return false;
            }
        }

        public Boolean Guardar(String numero)
        {
            if (ValidarNroInterno(numero))
            {
                nroInterno = int.Parse(numero);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void imprimir()
        {
            Console.WriteLine("Banco: " + banco + " Numero Interno: " + nroInterno);
            Console.WriteLine("Nombre del propietario: " + propietario);
            Console.WriteLine("Numero de cheque: " + numero);
            Console.WriteLine("Importe: " + importe);
        }

    }
}

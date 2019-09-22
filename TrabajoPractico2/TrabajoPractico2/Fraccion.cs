using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Fraccion
    {
        private int denominador;
        private int numerador;

      

        public int Denominador
        {
            get { return denominador; }
            set { denominador = value; }
        }
        public int Numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }

        public Fraccion suma(Fraccion f1, Fraccion f2)
        {

            Numerador = f1.Numerador * f2.Denominador + f2.Numerador * f1.Denominador;
            Denominador = f1.Denominador * f2.Denominador;
            return this;
        }

        public Fraccion resta(Fraccion f1, Fraccion f2)
        {
            Numerador = f1.Numerador * f2.Denominador - f2.Numerador * f1.Denominador;
            Denominador = f1.Denominador * f2.Denominador;
            return this;
        }
        public Fraccion multiplicacion(Fraccion f1, Fraccion f2)
        {
            Numerador = f1.Numerador * f2.Numerador;
            Denominador = f1.Denominador * f2.Numerador;
            return this;
        }

        public Fraccion division(Fraccion f1, Fraccion f2)
        {
            Numerador = f1.Numerador / f2.Denominador;
            Denominador = f1.Denominador / f2.Numerador;
            return this;
        }

        public void validaNumeraYdenomina(int num, int denom)
        {


            if (num == 0 || denom == 0)
            {
                throw new FraccionException("El número debe ser diferente de cero");

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Circulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja circulo");
            base.Dibujar();
        }
    }
}

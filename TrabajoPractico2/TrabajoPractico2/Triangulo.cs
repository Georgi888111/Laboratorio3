﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Triangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Rectangulo");
            base.Dibujar();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Rectangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja rectangulo");
            base.Dibujar();
        }
    }
}

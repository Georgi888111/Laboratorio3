using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class FraccionException : Exception
    {
        public FraccionException(String mensaje):base("Aviso!" + mensaje)
        {
           
              
            }
        }

  


    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lab___Crespo
{
    class Articulo
    {
        private string codigo;
        private double stockTotal;
        private double stockMinimo;
        private Deposito deposito;

        public string Codigo { get => codigo; set => codigo = value; }
        public double StockTotal { get => stockTotal; set => stockTotal = value; }
        public double StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        internal Deposito Deposito { get => deposito; set => deposito = value; }
    }
}

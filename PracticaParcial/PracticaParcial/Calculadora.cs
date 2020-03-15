using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int suma = 0;
            try
            {
                if (textValor1 != null && textValor2 != null)
                {
                    suma = Int32.Parse(textValor1.Text) + Int32.Parse(textValor2.Text);
                    MessageBox.Show("El resultado de la suma es: " + suma);
                }
                else
                {
                    MessageBox.Show("Para realizar la operacion es necesario ingresar dos números.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo ingrese numeros");
            }
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            int resta = 0;
            try
            {
                if (textValor1 != null && textValor2 != null)
                {
                    resta = Int32.Parse(textValor1.Text) - Int32.Parse(textValor2.Text);
                    MessageBox.Show("El resultado de la resta es: " + resta);
                }
                else
                {
                    MessageBox.Show("Para realizar la operacion es necesario ingresar dos números.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo ingrese numeros");
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            int multi = 0;
            try
            {
                if (textValor1 != null && textValor2 != null)
                {
                    multi = Int32.Parse(textValor1.Text) * Int32.Parse(textValor2.Text);
                    MessageBox.Show("El resultado de la multiplicacion es: " + multi);
                }
                else
                {
                    MessageBox.Show("Para realizar la operacion es necesario ingresar dos números.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo ingrese numeros");
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int div = 0;
                    if (textValor1 != null && textValor2 != null)
                    {
                        div = Int32.Parse(textValor1.Text) / Int32.Parse(textValor2.Text);
                        MessageBox.Show("El resultado de la division es: " + div);
                    }
                    else
                    {
                        MessageBox.Show("Para realizar la operacion es necesario ingresar dos números.");
                    }

                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("No se puede dividir por cero");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo ingrese numeros");
            }
        }
    }
}

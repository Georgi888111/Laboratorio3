using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWindowsFormsHilos
{
    public partial class Form2 : Form
    {

        private int y = 50;
        private int contador = 0;
        //public Form2()
        //{
        //    InitializeComponent();
        //}

        public Form2(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2("");
            formulario2.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Evento comun a todos, suena cuando se clickea sobre el boton
            //Console.Beep();
            //Se accede al boton por el nombre, se logra porque por parametro se envia un objeto, en este caso el boton.
            //if (((Button)sender).Name == "btn1")
            //{
            //    MessageBox.Show("Tocaste el primer boton");
            //}
            //else
            //{
            //    if (((Button)sender).Name == "btn2")
            //    {
            //        MessageBox.Show("Tocaste el segundo boton");
            //    }
            //    else
            //    {
            //    }
            //}
            //Se inicializa y crea la instancia del boton
            Button temp = new Button();

            //Les seteamos las propiedades
            temp.Width = 84;
            temp.Height = 36;
            temp.Location = new Point(53,y);
            y += 25;
            temp.Name = "boton " + contador.ToString();
            temp.Text = "boton #" + contador.ToString();
            contador++;
            //se le agrega el evento a los botones
            temp.Click += new EventHandler(handlerComun_Click);
            //se agrega el boton al form.
            Controls.Add(temp);
        }

        private void handlerComun_Click(object sender, EventArgs e)
        {
            //Console.Beep(((Button)sender).Location.Y * 10, 100);
             int posicion =((Button)sender).Location.Y * 10;
    }

      
    }
}

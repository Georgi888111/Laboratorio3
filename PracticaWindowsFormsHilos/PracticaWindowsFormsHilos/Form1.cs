using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWindowsFormsHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSaludo_Click(object sender, EventArgs e)
        {

            Thread hilo1 = new Thread(new ThreadStart(saludoUno));
            Thread hilo2 = new Thread(new ThreadStart(saludoDos));
            CheckForIllegalCrossThreadCalls = false;
          
                hilo1.Start();
                hilo2.Start();

                hilo1.Join();
                hilo2.Join();
               
            
        }


        

        public void saludoUno()
        {

            while (true)
            {
                Thread.Sleep(5000);
                lblMensaje.Text = "Hola vieji";
            }
        }
            
    
        public void saludoDos()
        {
            while (true)
            {
                Thread.Sleep(10000);
                lblMensaje.Text = "Hola guachi";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "Saluda la concha de tu madre!";
            MessageBox.Show("Aplicación del saludo eterno");
        }

        private void btnCambioForm_Click(object sender, EventArgs e)
        {
            //Form2 formulario2 = new Form2();
            //formulario2.Show();
            Form2 formulario2 = new Form2(textEnvio.Text);
            formulario2.Show();

        }

        private void btnGridView_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();
            formulario3.Show();
        }
    }
}

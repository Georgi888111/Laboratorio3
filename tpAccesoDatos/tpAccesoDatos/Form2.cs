using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpAccesoDatos
{
    public partial class Form2 : Form
    {

       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author();
                author.Id = textID.Text;
                author.Apellido = textApellido.Text;
                author.Nombre = textNombre.Text;
                author.Telefono = textTel.Text;
                author.Direccion = textDomi.Text;
                author.Ciudad = textCiudad.Text;
                author.Estado = textEstado.Text;
                author.CodPostal = textCodPos.Text;
                author.Contrato = checkContra.Checked;




                GestorAuthor ga = new GestorAuthor();
                ga.insertarDatos(author);
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

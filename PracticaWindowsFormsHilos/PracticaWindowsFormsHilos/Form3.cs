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
    public partial class Form3 : Form
    {
        int indiceClickeado;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar las filas o renglones
            int primeraFila = dataGridProductos.Rows.Add();
            //Agrega el contenido de cada celda
            dataGridProductos.Rows[primeraFila].Cells[0].Value = textCodigo.Text;
            dataGridProductos.Rows[primeraFila].Cells[1].Value = textNombre.Text;
            dataGridProductos.Rows[primeraFila].Cells[2].Value = textPrecio.Text;

            textCodigo.Text = "";
            textNombre.Text = "";
            textPrecio.Text = "";
        }
        //Metodo para clickear en la celda
        //si declaramos indiceCliqueado como global podemos acceder al indice desde diferentes metodos
        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //el indice del encabezado es  -1;
            indiceClickeado = e.RowIndex;

            if (indiceClickeado != -1)
            {
                lblInformacion.Text = dataGridProductos.Rows[indiceClickeado].Cells[1].Value.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (indiceClickeado != -1)
            {
                //el indice esta guardado del click anterior
                //se borra todo el renglon
                dataGridProductos.Rows.RemoveAt(indiceClickeado);
            }
        }

        private void pasarGrilla_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}

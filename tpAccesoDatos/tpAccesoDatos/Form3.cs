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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pubsDataSet1.publishers' Puede moverla o quitarla según sea necesario.
            this.publishersTableAdapter.Fill(this.pubsDataSet1.publishers);

        }

        private void mostrarDatos()
        {
            try
            {
                GestorPublishers gp = new GestorPublishers();
                DataTable dt = gp.mostrarDatos();
                dataGridPublishers.DataSource = dt;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Publishers publi = new Publishers();
                publi.Id = textId.Text;
                publi.Nombre = textNombre.Text;
                publi.Ciudad = textCiudad.Text;
                publi.Estado = textEstado.Text;
                publi.Pais = textPais.Text;
                GestorPublishers gp = new GestorPublishers();
                gp.insertarDatos(publi);
                mostrarDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Publishers publi = new Publishers();
                publi.Id = textId.Text;
                publi.Nombre = textNombre.Text;
                publi.Ciudad = textCiudad.Text;
                publi.Estado = textEstado.Text;
                publi.Pais = textPais.Text;
                GestorPublishers gp = new GestorPublishers();
                gp.actualizarDatos(publi);
                mostrarDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPublishers.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una fila de la grilla");
                    return;
                }
                DataGridViewRow row = dataGridPublishers.CurrentRow;
                String idPubli = row.Cells[0].Value.ToString();
                GestorPublishers gp = new GestorPublishers();
                gp.eliminarDatos(idPubli);
                mostrarDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("El campo que desea eliminar tiene una relacion con otra tabla, no es posible realizar la operacion");
            }
        }

        private void DataGridPublishers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seleccion = dataGridPublishers.SelectedRows.Count;
            if (seleccion == 1)
            {
                this.textId.Text = dataGridPublishers.CurrentRow.Cells[0].Value.ToString();
                this.textNombre.Text = dataGridPublishers.CurrentRow.Cells[1].Value.ToString();
                this.textCiudad.Text = dataGridPublishers.CurrentRow.Cells[2].Value.ToString();
                this.textEstado.Text = dataGridPublishers.CurrentRow.Cells[3].Value.ToString();
                this.textPais.Text = dataGridPublishers.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione sólo una fila y vuelva a intentar");
            }

        }

       
    }
}

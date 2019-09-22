using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using WindowsFormsApplication1.clases;



namespace WindowsFormsApplication1
{
    public partial class ABMEjemplo : Form
    {

        /*
         para poder seleccionar filas de la grilla cambiar la propiedad SelectionMode
         *  a FullRowSelect
         */
        public ABMEjemplo()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            try {
                GestorPersona gp = new GestorPersona();
                DataTable dt = gp.mostrarDatos();
                dgvClientes.DataSource = dt;
               

            }catch(Exception ex){
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try {
                Cliente c = new Cliente();
                c.Ciudad = txtCiudad.Text;
                c.Codpostal = txtCodPostal.Text;
                c.Compania = txtCompania.Text;
                c.Contacto = txtContacto.Text;
                c.Direccion = txtDireccion.Text;
                c.Fax = txtFax.Text;
                c.Id = txtId.Text;
                c.Pais = txtPais.Text;
                c.Region = txtRegion.Text;
                c.Telefono = txtTelefono.Text;
                c.Titulo = txtTitulo.Text;
                GestorPersona gp = new GestorPersona();
                gp.insertarDatos(c);
                mostrarDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.Ciudad = txtCiudad.Text;
                c.Codpostal = txtCodPostal.Text;
                c.Compania = txtCompania.Text;
                c.Contacto = txtContacto.Text;
                c.Direccion = txtDireccion.Text;
                c.Fax = txtFax.Text;
                c.Id = txtId.Text;
                c.Pais = txtPais.Text;
                c.Region = txtRegion.Text;
                c.Telefono = txtTelefono.Text;
                c.Titulo = txtTitulo.Text;
                GestorPersona gp = new GestorPersona();
                gp.actualizarDatos(c);
                mostrarDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow == null) {
                    MessageBox.Show("Seleccione una fila de la grilla");
                    return;
                }
                DataGridViewRow row = dgvClientes.CurrentRow;
                String idCliente = row.Cells["CustomerID"].Value.ToString();
                GestorPersona gp = new GestorPersona();
                gp.eliminarDatos(idCliente);
                mostrarDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void mostrarDatos() {
            try
            {
                GestorPersona gp = new GestorPersona();
                DataTable dt = gp.mostrarDatos();
                dgvClientes.DataSource = dt;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        private void btSearchId_Click(object sender, EventArgs e)
        {
            try
            {
                GestorPersona gp = new GestorPersona();
                DataTable dt = gp.buscarDatosXID(txtSearchId.Text);
                dgvClientes.DataSource = dt;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                GestorPersona gp = new GestorPersona();
                DataTable dt = gp.buscarDatosXNombre(txtSearchName.Text);
                dgvClientes.DataSource = dt;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgLista = ((DataGridView)sender);
            DataGridViewRow LinhaSelecionada = dgLista.SelectedCells[0].OwningRow;
            txtId.Text = Convert.ToString(LinhaSelecionada.Cells["CustomerID"].Value);
            txtCiudad.Text = Convert.ToString(LinhaSelecionada.Cells["City"].Value);
            txtCodPostal.Text = Convert.ToString(LinhaSelecionada.Cells["PostalCode"].Value);
            txtCompania.Text = Convert.ToString(LinhaSelecionada.Cells["CompanyName"].Value);
            txtContacto.Text = Convert.ToString(LinhaSelecionada.Cells["ContactName"].Value);
            txtDireccion.Text = Convert.ToString(LinhaSelecionada.Cells["Address"].Value);
            txtFax.Text = Convert.ToString(LinhaSelecionada.Cells["Fax"].Value);
            txtPais.Text = Convert.ToString(LinhaSelecionada.Cells["Country"].Value);
            txtRegion.Text = Convert.ToString(LinhaSelecionada.Cells["Region"].Value);
            txtTelefono.Text = Convert.ToString(LinhaSelecionada.Cells["Phone"].Value);
            txtTitulo.Text = Convert.ToString(LinhaSelecionada.Cells["ContactTitle"].Value);
        }

    }
}

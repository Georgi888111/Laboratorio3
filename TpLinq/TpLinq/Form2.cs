using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpLinq
{
    public partial class Form2 : Form
    {
        Conexion conexion = new Conexion();
        public Form2()
        {

            InitializeComponent();
            dataSupppliers.DataSource = conexion.todosProveedores();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Supplier suplier = new Supplier();
            suplier.Nombre = textNombre.Text;
           
            conexion.agregaProveedor(suplier);
            dataSupppliers.DataSource = conexion.todosProveedores();

        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Nombre = textNombre.Text;
            sup.Id = Int32.Parse(textId.Text);
            conexion.modificaProveedor(sup);
            dataSupppliers.DataSource = conexion.todosProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Nombre = textNombre.Text;
            sup.Id = Int32.Parse(textId.Text);
            conexion.eliminaProveedor(sup);
            dataSupppliers.DataSource = conexion.todosProveedores();
        }
    }
}

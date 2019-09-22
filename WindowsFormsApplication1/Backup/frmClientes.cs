using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();

            //Data Source=.\SQLEXPRESS;AttachDbFilename="E:\UTN\BECAS CONTROL F SQL SERVER\SQL2000.Sample.Databases.(Northwind,pubs)\SQL2000.Sample.Databases.(Northwind,pubs)\NORTHWND.MDF";Integrated Security=True;Connect Timeout=30;User Instance=True
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwind.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwind.Customers);
            
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nwind);

        }
    }
}

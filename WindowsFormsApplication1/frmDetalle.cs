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
    public partial class frmDetalle : Form
    {
        public frmDetalle()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nwind);

        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwind.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwind.Customers);

        }
    }
}

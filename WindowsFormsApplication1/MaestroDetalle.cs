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
    public partial class MaestroDetalle : Form
    {
        public MaestroDetalle()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nwind);

        }

        private void MaestroDetalle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwind.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.nwind.Order_Details);
            // TODO: This line of code loads data into the 'nwind.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwind.Orders);

        }
        
    }
}

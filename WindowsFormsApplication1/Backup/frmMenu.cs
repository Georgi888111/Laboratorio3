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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cargarGrillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarGrilla frm = new CargarGrilla();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalle frm = new frmDetalle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void maestroDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaestroDetalle frm = new MaestroDetalle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aBMEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEjemplo frm = new ABMEjemplo();
            frm.Show();
        }
    }
}

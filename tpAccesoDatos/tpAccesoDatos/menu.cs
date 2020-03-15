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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void BtnCargarAu_Click(object sender, EventArgs e)
        {
            Form1 cargaAu = new Form1();
            cargaAu.Show();
        }

        private void BtnIngresarAut_Click(object sender, EventArgs e)
        {
            Form2 cargaAu = new Form2();
            cargaAu.Show();
        }

        private void BtnABM_Click(object sender, EventArgs e)
        {
            Form3 formAbm = new Form3();
            formAbm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    public partial class Abm : Form
    {
        public Abm()
        {
            InitializeComponent();
        }

        private void Abm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.dataSet2.Suppliers);

        }

        private void BtnAdministrar_Click(object sender, EventArgs e)
        {
            int seleccion = dataGridView1.SelectedRows.Count;
            if (seleccion == 1)
            {

                Abm2 abmSupli = new Abm2();
                abmSupli.Show();
                abmSupli.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                abmSupli.txtCompName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                abmSupli.textContactName.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                abmSupli.textContactT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                abmSupli.txtAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                abmSupli.txtCity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                abmSupli.textRegion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                abmSupli.textPostal.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                abmSupli.textCountry.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                abmSupli.textPhone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                abmSupli.textFax.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                abmSupli.textHomeP.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();



            }
            else
            {
                Abm2 abmSupli = new Abm2();
                abmSupli.Show();
            }
        }

       
    }
}

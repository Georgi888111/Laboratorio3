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
    public partial class Abm2 : Form
    {
        public Abm2()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Suppliers supp = new Suppliers();
                supp.Id = Int32.Parse(txtId.Text);
                supp.CompanyName = txtCompName.Text;
                supp.ContactName = textContactName.Text;
                supp.ContactTitle = textContactT.Text;
                supp.Address = txtAddress.Text;
                supp.City = txtCity.Text;
                supp.Country = textCountry.Text;
                supp.CodPostal = textPostal.Text;
                supp.Phone = textPhone.Text;
                supp.Fax = textFax.Text;
                supp.Region = textRegion.Text;
                supp.HomePage = textHomeP.Text;

                GestorSupp gs = new GestorSupp();
                gs.insertarDatos(supp);
                
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
                Suppliers supp = new Suppliers();
                supp.Id = Int32.Parse(txtId.Text);
                supp.CompanyName = txtCompName.Text;
                supp.ContactName = textContactName.Text;
                supp.ContactTitle = textContactT.Text;
                supp.Address = txtAddress.Text;
                supp.City = txtCity.Text;
                supp.Country = textCountry.Text;
                supp.CodPostal = textPostal.Text;
                supp.Phone = textPhone.Text;
                supp.Fax = textFax.Text;
                supp.Region = textRegion.Text;
                supp.HomePage = textHomeP.Text;

                GestorSupp gs = new GestorSupp();
                gs.modificarDatos(supp);

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
               
                String idPubli = txtId.Text;
                GestorSupp gs = new GestorSupp();
                gs.eliminarDatos(idPubli);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("El campo que desea eliminar tiene una relacion con otra tabla, no es posible realizar la operacion");
            }
        }
    }
}

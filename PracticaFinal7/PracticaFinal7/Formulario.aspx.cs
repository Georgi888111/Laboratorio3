using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace PracticaFinal7
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checkVenci_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkVenci.Checked)
            {
                
             
               
                

                    textFecha.ValidaCheckFecha = true;

                


            }
           
           
        }

        protected void btnGuarda_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
              
                celdaCodigo.Text = codigo.Text;
                celdaDenominacion.Text = denominacion.Text;
                if(textFecha.ValidaCheckFecha == true)
                {
                    CeldaTieneVenci.Text = "Si";
                }
                else
                {
                    CeldaTieneVenci.Text = "No";
                }
                celdaVencimiento.Text = textFecha.getFecha().Text;
                celdaCodigoBarra.Text = tipoBarra.getBarra().SelectedValue;
                celdaUnidad.Text = unidadMedida.getMedida().SelectedValue;


                lista.Items.Add(new ListItem(codigo.Text));
                lista.Items.Add(new ListItem(denominacion.Text));
                lista.Items.Add(new ListItem(textFecha.getFecha().Text));
                lista.Items.Add(new ListItem(tipoBarra.getBarra().SelectedValue));
            }
        }

        protected void btnSesion_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session["codigo"] = codigo.Text;
                Session["denominacion"] = denominacion.Text;

                if (checkVenci.Checked)
                {
                    Session["tieneVenci"] = "Si";
                }
                else
                {
                    Session["tieneVenci"] = "No";
                }

                Session["vencimiento"] = textFecha.getFecha().Text;
                Session["barra"] = tipoBarra.getBarra().SelectedValue;
                Session["medida"] = unidadMedida.getMedida().SelectedValue;
                Response.Redirect("DatosSesionXML.aspx");

            }
        }
    }
}
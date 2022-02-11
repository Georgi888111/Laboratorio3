﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace FinalDiciembre
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void verForm_Click(object sender, EventArgs e)
        {
            Table2.Visible = false;
            Table1.Visible = true;
        }

        protected void verTabla_Click(object sender, EventArgs e)
        {
            Table2.Visible = true;
            Table1.Visible = false;
        }

        protected void checkVenci_CheckedChanged(object sender, EventArgs e)
        {

            if (checkPromo.Checked)
            {


                if (String.IsNullOrEmpty(textPorcentaje.Text))
                {

                    MessageBox.Show("Debe agregar el porcentaje de descuento");
                }




            }


        }

        protected void guardaDatos(object sender, EventArgs e)
        {
            if (IsValid)
            {
                celdaArt.Text = textArt.Text;
                celdaBarra.Text = CodigoBarra.getCodBarra().Text;
                celdaDescuento.Text = textPorcentaje.Text;
                celdaPrecio.Text = textPrecio.Text;
                celdaRubro.Text = Rubro.getRubro().SelectedValue;
                celdaVencimiento.Text = Vencimiento.getVenci().SelectedValue;
                if (checkPromo.Checked)
                {
                    celdaPromo.Text = "Si";
                }
                else
                {
                    celdaPromo.Text = "No";
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpControlesDeValidacion
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void validaFechaNac_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime fecha = DateTime.Now;
            int fdia = int.Parse(dia.Text);
            int faño = int.Parse(año.Text);
            int fmes = mesesList.SelectedIndex;
            DateTime fechaIngre = new DateTime(faño,(fmes+1),fdia);
            if (faño < 1930 || fechaIngre > fecha) 
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }

        }

        protected void boton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Response.Redirect("Ingreso.aspx");
            }
        }

        protected void contraseñaValida_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
            String contra = password.Text;
            for (int i = 0; i < contra.Length; i++)
            {
                if(contra.Contains("!")|| contra.Contains("@")|| contra.Contains("#")||contra.Contains("$")|| contra.Contains("%")|| contra.Contains("^")|| contra.Contains("&")|| contra.Contains("*")|| contra.Contains("+")|| contra.Contains(";") || contra.Contains(":"))
                {
                    args.IsValid = true;
                    break;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void validaCondic_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool combo = cboBoxTerm1.Checked;
            if (combo)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}
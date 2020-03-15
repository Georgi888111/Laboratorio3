using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Crespo
{
    public partial class EmpleadoASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session["apellido"] = ape.Text;
                Session["nombre"] = nom.Text;
                //Session["cuit"] = cuit.Text;
                //Session["tipoContrato"] = TipoDeContrato.Text;
                Session["regimen"] = DropDownListRegimen.SelectedItem.Text;
                //Session["delegacion"] = Delegacion1.Text;
                //Session["estudios"] = Estudios.Text;
                Session["descripcion"] = Descripcion.Text;
                Response.Redirect("resultadoASP.aspx");

            }
        }
    }
}
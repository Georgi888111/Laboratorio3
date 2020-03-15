using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpSesiones
{
    public partial class datosPersonales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["nombre"] = nombre.Text;
            Session["apellido"] = apellido.Text;
            Session["dni"] = dni.Text;
            Session["domicilio"] = domicilio.Text;
            Session["nacionalidad"] = nacionalidad.Text;
            Session["sexo"] = sexo.SelectedItem.Text;
            Session["fechaNac"] = fechaNac.Text;
            Response.Redirect("estudios.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpSesiones
{
    public partial class trabajos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["periodo"] = periodo.Text;
            Session["lugar"] = lugar.Text;
            Session["tarea"] = tarea.Text;
            
            Response.Redirect("idioma.aspx");
        }
    }
}
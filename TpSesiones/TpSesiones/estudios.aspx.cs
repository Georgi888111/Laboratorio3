using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpSesiones
{
    public partial class estudios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["nivel"] = nivelEstu.SelectedItem.Text;
            Session["titulo"] = titulo.Text;
            Session["establecimiento"] = establecimiento.Text;

            Response.Redirect("trabajos.aspx");
        }
    }
}
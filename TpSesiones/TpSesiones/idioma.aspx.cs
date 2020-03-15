using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpSesiones
{
    public partial class idioma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["idioma"] = idiomas.SelectedItem.Text;
            Session["nivel"] = nivelIdio.SelectedItem.Text;

            Response.Redirect("resumen.aspx");
        }
    }
}
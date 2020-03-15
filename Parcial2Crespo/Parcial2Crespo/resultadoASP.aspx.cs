using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Crespo
{
    public partial class resultadoASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["apellido"].ToString();
            Label2.Text = Session["nombre"].ToString();
            Label3.Text = Session["regimen"].ToString();
            Label4.Text = Session["descripcion"].ToString();
        }
    }
}
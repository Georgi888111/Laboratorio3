using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaParcialFinal
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["nombre"].ToString();
            Label2.Text = Session["apellido"].ToString();
            Label3.Text = Session["telefono"].ToString();
            Label4.Text = Session["sexo"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Response.Redirect("Formulario.aspx");
            }
        }
    }
}
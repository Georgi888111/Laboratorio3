using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal1
{
    public partial class resultadoASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text=Session["apellido"].ToString();
            Label2.Text=Session["nombre"].ToString();
            Label3.Text = Session["dni"].ToString();
            Label4.Text = Session["contrato"].ToString();
            Label5.Text = Session["regimen"].ToString();
            Label6.Text = Session["delegacion"].ToString();
            Label7.Text = Session["estudios"].ToString();
            Label8.Text = Session["descripcion"].ToString();
        }
    }
}
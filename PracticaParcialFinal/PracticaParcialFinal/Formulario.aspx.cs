using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaParcialFinal
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session["nombre"] = TextBox1.Text;
                Session["apellido"] = TextBox2.Text;
                Session["telefono"] = TextBox3.Text;
                Session["sexo"] = radioBtnSexo.SelectedItem.Text;
                
               
                Response.Redirect("Ingreso.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
            Label2.Text = TextBox2.Text;
            Label3.Text = TextBox3.Text;
        }
    }
}
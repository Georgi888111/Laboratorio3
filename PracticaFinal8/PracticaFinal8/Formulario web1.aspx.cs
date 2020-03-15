using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal8
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void verForm_Click(object sender, EventArgs e)
        {
            DropCurso2.Visible = true;
            DropDownAlumno.Visible = true;
            Table1.Visible = false;
        }

        protected void verTabla_Click(object sender, EventArgs e)
        {
            Table1.Visible = true;
            DropCurso2.Visible = false;
            DropDownAlumno.Visible = false;
           
        }
    }
}
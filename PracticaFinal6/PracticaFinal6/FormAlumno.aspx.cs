using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal6
{
    public partial class FormAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarAlu_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textDni.getDni().Text)) || !(String.IsNullOrEmpty(textNombre.getNombre().Text)) || !(String.IsNullOrEmpty(idAño.Text)))
            {
                Conexion conexion = new Conexion();
                Alumno alumno = new Alumno();


                alumno.Nombre = textNombre.getNombre().Text;
                alumno.Dni = Int32.Parse(textDni.getDni().Text);
                //alumno.Curso.Id = Int32.Parse(Session["id"].ToString());
                alumno.Curso.Id = 2;
                alumno.Año = Int32.Parse(idAño.Text);
                conexion.agregarAlumno(alumno);
            }
        }
    }
}
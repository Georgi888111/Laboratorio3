using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal6
{
    public partial class FormProfesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProf_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textDni.getDni().Text)) || !(String.IsNullOrEmpty(textNombre.getNombre().Text)) || !(String.IsNullOrEmpty(idMateria.Text)))
            {
                Conexion conexion = new Conexion();
                Profesor profesor = new Profesor();

                profesor.Materia = idMateria.Text;
                profesor.Nombre = textNombre.getNombre().Text;
                profesor.Dni = Int32.Parse(textDni.getDni().Text);
                //profesor.Curso.Id = Int32.Parse(Session["id"].ToString());
                profesor.Curso.Id = 2;
                conexion.agregarProfesor(profesor);
            }

        }

      
    }
}
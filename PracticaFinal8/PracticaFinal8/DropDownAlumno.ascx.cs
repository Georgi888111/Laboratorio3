using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal8
{
    public partial class DropDownAlumno : System.Web.UI.UserControl
    {
        List<Alumno> alumnos = new List<Alumno>();
        public DropDownList getAlumno()
        {
            return this.DropAlumno;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        





        }
          public void cargaAlumnos(int id)
        {
            
            Conexion conexion = new Conexion();
            alumnos = conexion.traerTodosAlumnos(id);
            DropAlumno.DataSource = alumnos;
            DropAlumno.Items.Clear();
            foreach (Alumno alu in alumnos)
            {
                DropAlumno.Items.Add(alu.Nombre);
               
            }

        }

    }
}
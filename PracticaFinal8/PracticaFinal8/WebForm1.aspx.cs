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
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DropCurso2.cargaCursos();
            DropCurso2.traeAlumnos += (DropCurso_cargaDropAlumnos);



        }


        protected void DropCurso_cargaDropAlumnos(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            int id = conexion.retornaId(DropCurso2.DivisionSelec);
         
                DropDownAlumno.cargaAlumnos(id);
           
    }
    }
}
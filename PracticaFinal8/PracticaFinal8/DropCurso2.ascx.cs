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
    public partial class DropCurso2 : System.Web.UI.UserControl
    {
        public List<Curso> cursos = new List<Curso>();
        public event EventHandler traeAlumnos;
        private String divisionSelec;

        public string DivisionSelec { get => divisionSelec; set => divisionSelec = value; }

        public DropDownList getCurso()
        {
            return this.DropDownList1;
        }

     
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public void cargaCursos()
        {
            
            Conexion conexion = new Conexion();
            cursos = conexion.traerTodosCursos();


            DropDownList1.DataSource = cursos;

            foreach (Curso cur in cursos)
            {
                DropDownList1.Items.Add(cur.Division);

            }
        }

        protected void envioId(object sender, EventArgs e)
        {
           
           
            divisionSelec = DropDownList1.SelectedItem.Value;

            this.traeAlumnos?.Invoke(sender, e);
        }
    }
}
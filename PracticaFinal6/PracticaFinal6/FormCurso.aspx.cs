using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PracticaFinal6
{
    public partial class FormCurso : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void idAgregar_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(id.Text)) || !(String.IsNullOrEmpty(idDivision.Text)) || !(String.IsNullOrEmpty(idHoras.Text)))
            {
                Conexion conexion = new Conexion();
                Curso curso = new Curso();
                curso.Id = Int32.Parse(id.Text);
                curso.Division = idDivision.Text;
                curso.Horas = Int32.Parse(idHoras.Text);
                
                conexion.agregaCurso(curso);
                
            }
        }

        protected void idProfesor_Click(object sender, EventArgs e)
        {
            Session["id"] = id.Text;
            Response.Redirect("FormProfesor.aspx");
        }

        protected void idAlumno_Click(object sender, EventArgs e)
        {
            Session["id"] = id.Text;
            Response.Redirect("FormAlumno.aspx");
        }

        protected void btnXml_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            List<Profesor> profesores = conexion.traerTodosProfesores();
            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Georgi\\source\\repos\\PracticaFinal6\\PracticaFinal6\\bin\\datosColegioXML.xml", Encoding.UTF8);
            //writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Profesores");
            foreach (Profesor prof in profesores)
            {
                writer.WriteStartElement("Profesor");
                writer.WriteAttributeString("Materia", prof.Materia);
                writer.WriteElementString("Dni", prof.Dni.ToString());
                writer.WriteElementString("Nombre", prof.Nombre);
                writer.WriteStartElement("Curso");
                writer.WriteAttributeString("Division", prof.Curso.Division);
                writer.WriteElementString("Horas", prof.Curso.Horas.ToString());
                writer.WriteStartElement("Alumnos");
                foreach(Alumno alu in prof.Curso.Alumnos)
                {
                    writer.WriteStartElement("Alumno");
                    writer.WriteAttributeString("Dni", alu.Dni.ToString());
                    writer.WriteElementString("Nombre", alu.Nombre);
                    writer.WriteElementString("Año", alu.Año.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        protected void btnJson_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            List<Profesor> profesores = conexion.traerTodosProfesores();
          
            
            String outputJSON = JsonConvert.SerializeObject(profesores, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("colegio.json", outputJSON);
    
            

          
          

        }
    }
}
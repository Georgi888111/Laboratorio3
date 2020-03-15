using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PracticaFinal8
{
    public class Conexion
    {
        protected SqlConnection con = null;
        protected SqlCommand cmd;

        public SqlConnection Conectar()
        {
            try
            {
                this.con = new SqlConnection("Data Source=DESKTOP-0S169QT;Initial Catalog=Colegio;Integrated Security=True");
                this.con.Open();
                return this.con;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }

        public void Desconectar()
        {
            try
            {
                this.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public List<Curso> traerTodosCursos()
        {
            List<Curso> cursos = new List<Curso>();
            this.cmd = new SqlCommand("SELECT * FROM Curso", this.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cursos.Add(convertirCurso(reader));

            }
            this.Desconectar();

            return cursos;
        }
        public int retornaId(String division)
        {
            int id = 0;
            this.cmd = new SqlCommand("SELECT id from Curso where division = '" + division + "'", this.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              id= Convert.ToInt32(reader["id"]);

            }
            this.Desconectar();

            return id;
        }

        public Curso convertirCurso(SqlDataReader reader)
        {


            Curso curso = new Curso();
            curso.Id = Convert.ToInt32(reader["id"]);
            curso.Division = Convert.ToString(reader["division"]);
            curso.Horas = Convert.ToInt32(reader["horas"]);
           

            return curso;




        }

        public List<Alumno> traerTodosAlumnos(int idCurso)
        {
            List<Alumno> alumnos = new List<Alumno>();
            this.cmd = new SqlCommand("SELECT * FROM Alumno where fkCurso =" + idCurso, this.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                alumnos.Add(convertirAlumno(reader));

            }
            this.Desconectar();

            return alumnos;
        }


        public Alumno convertirAlumno(SqlDataReader reader)
        {


            Alumno alumno = new Alumno();
            alumno.Dni = Convert.ToInt32(reader["dni"]);
            alumno.Año = Convert.ToInt32(reader["año"]);

            alumno.Nombre = Convert.ToString(reader["nombre"]);


            return alumno;




        }
    }
}
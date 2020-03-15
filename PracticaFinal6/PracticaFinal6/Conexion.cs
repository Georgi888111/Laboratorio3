using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PracticaFinal6
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

        public void agregaCurso(Curso curso)
        {
            
            string query = "INSERT INTO Curso (id,horas,division) VALUES (@id, @horas, @division)";



            cmd = new SqlCommand(query,this.Conectar());
            cmd.Parameters.AddWithValue("@id", curso.Id);
            cmd.Parameters.AddWithValue("@horas", curso.Horas);
            cmd.Parameters.AddWithValue("@division", curso.Division);
           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            //this.Desconectar();

        }

        public void agregarProfesor(Profesor profesor)
        {
            string query = "INSERT INTO Profesor (dni,nombre,materia,fk_Curso) VALUES (@dni, @nombre,@materia,@fk_Curso)";

            cmd = new SqlCommand(query, this.Conectar());
            cmd.Parameters.AddWithValue("@dni", profesor.Dni);
            cmd.Parameters.AddWithValue("@nombre", profesor.Nombre);
            cmd.Parameters.AddWithValue("@materia", profesor.Materia);
            cmd.Parameters.AddWithValue("@fk_Curso", profesor.Curso.Id);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            //this.Desconectar();

        }

        public void agregarAlumno(Alumno alumno)
        {
            string query = "INSERT INTO Alumno (dni,nombre,año,fkCurso) VALUES (@dni, @nombre,@año,@fkCurso)";

            cmd = new SqlCommand(query, this.Conectar());
            cmd.Parameters.AddWithValue("@dni", alumno.Dni);
            cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
            cmd.Parameters.AddWithValue("@año", alumno.Año);
            cmd.Parameters.AddWithValue("@fkCurso", alumno.Curso.Id);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            //this.Desconectar();

        }

        public List<Profesor> traerTodosProfesores()
        {
          
            List<Profesor> profesores = new List<Profesor>();
            this.cmd = new SqlCommand("SELECT * FROM Profesor", this.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                profesores.Add(ConvertirProfesor(reader));
                
            }
            this.Desconectar();
            
            return profesores;
        }

       

      

        private Profesor ConvertirProfesor(SqlDataReader reader)
        {

            Profesor profesor = new Profesor();

            profesor.Dni = Convert.ToInt32(reader["dni"]);
            profesor.Nombre = Convert.ToString(reader["nombre"]);
            profesor.Materia = Convert.ToString(reader["materia"]);
            profesor.Curso = traeCursoProf(Convert.ToInt32(reader["fk_Curso"]));
            return profesor;





        }

        public Curso traeCursoProf(int idCurso)
        {

            Curso curso = new Curso();
            cmd = new SqlCommand("SELECT * FROM Curso WHERE id =" + idCurso, this.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                convertirCurso(reader, curso);

            }
            this.Desconectar();
            return curso;
        }

        public Curso convertirCurso(SqlDataReader reader, Curso curso)
        {
           


               curso.Id = Convert.ToInt32(reader["id"]);
               curso.Division = Convert.ToString(reader["division"]);
               curso.Horas = Convert.ToInt32(reader["horas"]);
               curso.Alumnos = traeAlumnosCurs(curso.Id, curso);

               return curso;




        }

        public List<Alumno> traeAlumnosCurs(int idCurso, Curso curso)
        {
           
            List<Alumno> alumnos = new List<Alumno>();
            this.cmd = new SqlCommand("SELECT * FROM Alumno where fkCurso =" + idCurso, this.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                alumnos.Add(ConvertirAlumno(reader, curso));

            }
            this.Desconectar();

           
            return alumnos;
        }

        private Alumno ConvertirAlumno(SqlDataReader reader, Curso curso)
        {


            Alumno alumno = new Alumno();
            alumno.Dni = Convert.ToInt32(reader["dni"]);
            alumno.Nombre = Convert.ToString(reader["nombre"]);
            alumno.Año = Convert.ToInt32(reader["año"]);
            //alumno.Curso = curso;
            return alumno;
        }



    }
}
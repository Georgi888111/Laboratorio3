using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PracticaFinal6
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "<Profesores><Profesor Materia = 'CienciasSociales'><Dni>12456499</Dni><Nombre>MilagrosSalas</Nombre><Curso Division = '2b'><Horas>12</Horas><Alumnos><Alumno Dni = '12345666'><Nombre>MelisaFunes</Nombre><Año>2009</Año></Alumno></Alumnos></Curso></Profesor></Profesores>";
        }
        [WebMethod]
        public string HelloWorld2()
        {
            return "['Dni': '12456499','Nombre': 'MilagrosSalas','Materia': 'CienciasSociales','Curso': {'Id': 1,'Division': '2b','Horas': '12'}]'";
           
          }

        }
    }


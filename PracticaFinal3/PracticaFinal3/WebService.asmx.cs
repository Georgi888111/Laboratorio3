using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PracticaFinal3
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public String getPersonaXML()
        {
            return "<personas><persona bloquedo = 'NO'><datosPersonales sexo='M'><apellido>ROLDAN</apellido><nombre>Carlos</nombre><edad>45</edad><nacionalidad>argentino</nacionalidad></datosPersonales><antecedentes>Universitario completo</antecedentes></persona></personas>";
        }
    } 
}

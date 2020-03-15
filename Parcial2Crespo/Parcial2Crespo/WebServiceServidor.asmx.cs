using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Parcial2Crespo
{
    /// <summary>
    /// Descripción breve de WebServiceServidor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceServidor : System.Web.Services.WebService
    {

        [WebMethod]
      public int suma(int input1, int input2)
        {
            return input1 + input2;
        }

        
    }
}

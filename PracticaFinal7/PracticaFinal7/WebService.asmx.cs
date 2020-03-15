using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PracticaFinal7
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
        public string getArticuloXML()
        {
            return "<articulos>" +
                   "<articulo codigo='7654852369'>" +
                   "<denominacion>Aire Acondicionado</denominacion>" +
                   "<vencimiento>No</vencimiento>" +
                   "<fechaVto>12/12/2014</fechaVto>" +
                   "<unidadMedida>Unidad</unidadMedida>" +
                   "<tipoCodigo>EAN</tipoCodigo>" +
                   "</articulo>" +
                   "</articulos>";

        }
    }
}

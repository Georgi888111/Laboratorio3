using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PracticaFinal3
{
    public partial class DatosSesionXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Georgi\\source\\repos\\PracticaFinal3\\PracticaFinal3\\bin\\datosXML.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("personas");
            writer.WriteStartElement("persona");
            writer.WriteAttributeString("bloqueado", (string)Session["bloqueado"]);
            writer.WriteStartElement("datosPersonales");
            writer.WriteAttributeString("sexo", (string)Session["sexo"]);
            writer.WriteElementString("apellido", (string)Session["apellido"]);
            writer.WriteElementString("nombre", (string)Session["nombre"]);
            writer.WriteElementString("edad", (string)Session["edad"]);
            writer.WriteElementString("nacionalidad", (string)Session["nacionalidad"]);
            writer.WriteEndElement();
            writer.WriteStartElement("antecedentes");
            writer.WriteString((string)Session["antecedentes"]);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();
        }
    }
}
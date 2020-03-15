using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PracticaFinal7
{
    public partial class DatosSesionXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Georgi\\source\\repos\\PracticaFinal7\\PracticaFinal7\\bin\\datosXML.xml", Encoding.UTF8);
             writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Articulos");
            writer.WriteStartElement("Artículo");
            writer.WriteAttributeString("Código", (String)Session["codigo"]);
            writer.WriteElementString("Denominacion", (String)Session["denominacion"].ToString());
            writer.WriteElementString("Vencimiento", (String)Session["tieneVenci"].ToString());
            writer.WriteElementString("FechaVto", (String)Session["vencimiento"]);
            writer.WriteElementString("UnidadMedida", (String)Session["medida"]);
            writer.WriteElementString("TipoCodigo", (String)Session["barra"]);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
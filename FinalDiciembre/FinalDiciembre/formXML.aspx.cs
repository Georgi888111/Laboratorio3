using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace FinalDiciembre
{
    public partial class formXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnXml_Click(object sender, EventArgs e)
        {
            int filas = Int32.Parse(textFilas.Text);
            int columnas = Int32.Parse(textColumnas.Text);
            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Georgi\\source\\repos\\FinalDiciembre\\FinalDiciembre\\bin\\datosXML.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("table");

            for (int i = 0; i < filas; i++)
            {
            writer.WriteStartElement("tr"); 

               for (int j = 0; j < filas; j++)
                {
                    writer.WriteStartElement("td");
                    
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();



        }
    }
}
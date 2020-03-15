using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace FinalDiciembre
{
    public partial class LeerXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load("C:\\Users\\Georgi\\source\\repos\\FinalDiciembre\\FinalDiciembre\\bin\\datosXML.xml");
            XmlNodeList tabla = xDoc.GetElementsByTagName("table");

            XmlNodeList fila = ((XmlElement)tabla[0]).GetElementsByTagName("tr");


        }
    }
}
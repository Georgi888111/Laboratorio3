using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PracticaFinal6
{
    public partial class WebServiceCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnXml_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            XmlDocument xDoc = new XmlDocument();

            xDoc.LoadXml(client.HelloWorld());
            XmlNodeList profesores = xDoc.GetElementsByTagName("Profesores");
            XmlNodeList profesor = ((XmlElement)profesores[0]).GetElementsByTagName("Profesor");
            Label1.Text = xDoc.GetElementsByTagName("Profesor").Item(0).Attributes[0].InnerText;
            
                Label2.Text = xDoc.GetElementsByTagName("Dni")[0].InnerText;  
                Label3.Text = xDoc.GetElementsByTagName("Curso").Item(0).Attributes[0].InnerText;
              Label4.Text = xDoc.GetElementsByTagName("Horas")[0].InnerText;

        }

        protected void btnJson_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string outputJSON = client.HelloWorld2();
            Profesor profe = ser.Deserialize<Profesor>(outputJSON);
          
            Label1.Text = profe.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PracticaFinal3
{
    public partial class WebServiceCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonWeb_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebServiceSoapClient client = new ServiceReference1.WebServiceSoapClient();
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(client.getPersonaXML());

            XmlNodeList apellido = xDoc.GetElementsByTagName("apellido");
            textApe.Text = apellido[0].InnerText; 
            XmlNodeList nombre = xDoc.GetElementsByTagName("nombre");
            textNomb.Text = nombre[0].InnerText;
            XmlNodeList edad = xDoc.GetElementsByTagName("edad");
            textEdad.Text = edad[0].InnerText;
            XmlNodeList nacionalidad = xDoc.GetElementsByTagName("nacionalidad");
            textNacio.Text =  nacionalidad[0].InnerText;
            XmlNodeList antecedentes = xDoc.GetElementsByTagName("antecedentes");
            textAntec.Text = antecedentes[0].InnerText;
        }
                }
            }
  
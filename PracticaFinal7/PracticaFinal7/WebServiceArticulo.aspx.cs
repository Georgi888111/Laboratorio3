using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PracticaFinal7
{
    public partial class WebServiceArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference.WebServiceSoapClient client = new ServiceReference.WebServiceSoapClient();
            XmlDocument xDoc = new XmlDocument();

            xDoc.LoadXml(client.getArticuloXML());
            XmlNodeList articulos = xDoc.GetElementsByTagName("articulos");
            XmlNodeList articulo = ((XmlElement)articulos[0]).GetElementsByTagName("articulo");
            String codigo = xDoc.GetElementsByTagName("articulo").Item(0).Attributes[0].InnerText;
            textCodigo.Text = codigo;
            foreach (XmlElement art in articulo)
            { //textDenom.Text = xDoc.GetElementsByTagName("denominacion")[0].innerText;  
                XmlNodeList denom = art.GetElementsByTagName("denominacion");
                textDenom.Text = denom[0].InnerText;
                XmlNodeList venci = art.GetElementsByTagName("vencimiento");
                textTieneVenc.Text = venci[0].InnerText;
                XmlNodeList fecha = art.GetElementsByTagName("fechaVto");
                textVenci.Text = fecha[0].InnerText;
                XmlNodeList unidad = art.GetElementsByTagName("unidadMedida");
                textMedida.Text = unidad[0].InnerText;
                XmlNodeList tipoCod = art.GetElementsByTagName("tipoCodigo");
                textTipoCod.Text = tipoCod[0].InnerText;
            }
            

        }
    }
    }

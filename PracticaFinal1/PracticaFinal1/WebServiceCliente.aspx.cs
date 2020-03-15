using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal1
{
    public partial class WebServiceCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Resolver_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(valor1.Text)|| !String.IsNullOrEmpty(valor2.Text))
            {
                int val1 = Int32.Parse(valor1.Text);
                int val2 = Int32.Parse(valor2.Text);
                ServiceReference1.WebServiceServidorSoapClient client = new ServiceReference1.WebServiceServidorSoapClient();
                int result = client.suma(val1, val2);
                resultado.Text = result.ToString();
            }
        }
    }
}
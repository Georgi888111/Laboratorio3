using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Crespo
{
    public partial class WebServicesCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBox1.Text) || !String.IsNullOrEmpty(TextBox2.Text))
            {
                int valor1 = Int32.Parse(TextBox1.Text);
                int valor2 = Int32.Parse(TextBox2.Text);
                ServiceReference1.WebServiceServidorSoapClient client = new ServiceReference1.WebServiceServidorSoapClient();
                int result = client.suma(valor1, valor2);
                resultado.Text = result.ToString();

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpWebServices
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.q.Text))
            {
                double valor = Double.Parse(this.q.Text);
                String inputUnit = this.ddl1.SelectedValue;
                String outputUnit = this.ddl2.SelectedValue;
                ServiceReference1.ConvertSoapClient client = new ServiceReference1.ConvertSoapClient();
                String result = client.GetConversion(valor, inputUnit, outputUnit);
                this.TextBox3.Text = result;
            }
        }
    }
}
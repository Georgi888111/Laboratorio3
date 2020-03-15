using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal3
{
    public partial class Edad : System.Web.UI.UserControl
    {
        public TextBox getEdad()
        {
            return this.edadCtrol;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void validaEdad(object source, ServerValidateEventArgs args)
        {
            int edad = Int32.Parse(edadCtrol.Text);
            if (edad < 18 || edad > 70)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal6
{
    public partial class textDni : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public TextBox getDni()
        {
            return this.dni;
        }
        protected void validaLargoDni(object source, ServerValidateEventArgs args)
        {
           if(this.dni.Text.Length >8 || this.dni.Text.Length < 7)
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

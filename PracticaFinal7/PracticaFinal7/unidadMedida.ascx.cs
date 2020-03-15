using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal7
{
    public partial class unidadMedida : System.Web.UI.UserControl
    {
        public DropDownList getMedida()
        {
            return this.uMedida;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
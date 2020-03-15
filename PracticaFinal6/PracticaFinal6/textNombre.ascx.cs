using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal6
{
    public partial class textNombre : System.Web.UI.UserControl
    {
        public TextBox getNombre()
        {
            return this.nombre;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
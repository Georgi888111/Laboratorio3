using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal3
{
    public partial class Nacionalidad : System.Web.UI.UserControl
    {
        public DropDownList getNacionalidad()
        {
            return this.Nacion;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
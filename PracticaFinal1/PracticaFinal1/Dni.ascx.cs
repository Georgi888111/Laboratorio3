using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal1
{
  
   
    public partial class Dni : System.Web.UI.UserControl
    {
        public TextBox getDni()
        {
            return this.dni;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
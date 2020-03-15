using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal3
{
    public partial class masterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void muestra_Click(object sender, EventArgs e)
        {
            ContentPlaceHolder2.Visible = true;
        }

        protected void oculta_Click(object sender, EventArgs e)
        {
            ContentPlaceHolder2.Visible = false;
        }
    }
}
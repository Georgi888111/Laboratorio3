using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal7
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void verForm_Click(object sender, EventArgs e)
        {
            ContentPlaceHolder2.Visible = true;
            ContentPlaceHolder3.Visible = false;
        }

        protected void verTabla_Click(object sender, EventArgs e)
        {
            ContentPlaceHolder3.Visible = true;
            ContentPlaceHolder2.Visible = false;
        }
    }
}
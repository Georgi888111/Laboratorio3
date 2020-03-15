using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal7
{
    public partial class tipoBarra : System.Web.UI.UserControl
    {
        public RadioButtonList getBarra()
        {
            return this.tipoCodBarra;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
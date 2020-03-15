using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalDiciembre
{
    
    public partial class CodigoBarra : System.Web.UI.UserControl
    {
        public TextBox getCodBarra()
        {
            return this.textCodigo;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
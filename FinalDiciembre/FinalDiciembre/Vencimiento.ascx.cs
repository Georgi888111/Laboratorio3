using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalDiciembre
{
    public partial class Vencimiento : System.Web.UI.UserControl
    { 
        public RadioButtonList getVenci()
        {
            return this.radioVenci;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
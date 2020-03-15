using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalDiciembre
{
    public partial class Rubro : System.Web.UI.UserControl
    {
        public DropDownList getRubro()
        {
            return this.dropRubro;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
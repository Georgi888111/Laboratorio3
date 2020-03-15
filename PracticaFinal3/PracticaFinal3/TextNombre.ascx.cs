using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal3
{
    public partial class TextNombre : System.Web.UI.UserControl
    {
        public TextBox getNombre()
        {
            return this.textBoxPersonal;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }


    
        
    }
}
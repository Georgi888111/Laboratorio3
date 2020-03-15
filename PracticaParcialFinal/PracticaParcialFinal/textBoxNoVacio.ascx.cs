using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaParcialFinal
{
    public partial class textBoxNoVacio : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool IfNotValidates()
        {
            return String.IsNullOrEmpty(this.TextBox1.Text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpCreaciónCU
{
    public partial class TextBoxMayorEdad : System.Web.UI.UserControl
    {
        public event EventHandler verifEdad;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void OnClick(object sender)
        {
            if (verifEdad != null)
            {
                this.verifEdad(sender, new EventArgs());
            }
        }

         public bool esMayor()
        {
            int valor=0;
            if (!String.IsNullOrEmpty(TextBox1.Text))
            {
              valor = Int32.Parse(TextBox1.Text);
            }
            if (valor >= 18) 
                {
                    return true;
            }
            else
            {
                return false;
            } 
        }

    }
}
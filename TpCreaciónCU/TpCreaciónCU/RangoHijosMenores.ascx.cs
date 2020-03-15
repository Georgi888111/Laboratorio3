using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpCreaciónCU
{
    public partial class RangoHijosMenores : System.Web.UI.UserControl
    {
        public event EventHandler cantidadHijos;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public virtual void OnClick(object sender)
        {

            if (this.cantidadHijos != null)
            {

                this.cantidadHijos(sender, new EventArgs());
            }

        }
         
        public bool validaHijos()
        {
            int valor = 0;
            if (!String.IsNullOrEmpty(TextBox1.Text))
            {
                valor = Int32.Parse(TextBox1.Text);
            }
            if(valor<=0 || valor >= 18)
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
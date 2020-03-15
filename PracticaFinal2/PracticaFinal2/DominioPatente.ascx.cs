using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal2
{
    public partial class DominioPatente : System.Web.UI.UserControl
    {
        public TextBox getPatente()
        {
            return this.textDomPate;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void validaFormatoPatente(object source, ServerValidateEventArgs args)
        {
            string patente = this.textDomPate.Text;
            if (soloLetras(String.Concat(patente[0], patente[1])) && soloNumeros(String.Concat(patente[2], patente[3], patente[4])) && soloLetras(String.Concat(patente[5], patente[6])))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        private bool soloLetras(string a)
        {
            Regex Val = new Regex(@"[a-zA-ZñÑ\s]");
            if (Val.IsMatch(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool soloNumeros(string a)
        {
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(a))
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
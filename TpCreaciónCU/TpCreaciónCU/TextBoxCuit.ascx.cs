using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpCreaciónCU
{
    public partial class TextBoxCuit : System.Web.UI.UserControl
    {
        public event EventHandler verifCuit;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public virtual void OnClick(object sender)
        {
            if (verifCuit != null)
            {

                this.verifCuit(sender, new EventArgs());

            }
        }
     
    

        public bool ValidateCuit()
        {
            string Cuit = this.TextBox1.Text.ToString();
            Regex rg = new Regex("[A-Z_a-z]");
            Cuit = Cuit.Replace("-", "");

            if (rg.IsMatch(Cuit))
                return false;
            if (Cuit.Length != 11)
                return false;

            char[] cuitArray = Cuit.ToCharArray();
            double sum = 0; int bint = 0; int j = 7;

            for (int i = 5, c = 0; c != 10; i--, c++)
            {
                if (i >= 2) sum += (Char.GetNumericValue(cuitArray[c]) * i);
                else
                    bint = 1; if (bint == 1 && j >= 2) { sum += (Char.GetNumericValue(cuitArray[c]) * j); j--; }
            }

            if ((cuitArray.Length - (sum % 11)) == Char.GetNumericValue(cuitArray[cuitArray.Length - 1]))
                return true;
            return false;
        }
    }
}
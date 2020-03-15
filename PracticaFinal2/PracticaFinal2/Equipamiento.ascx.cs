using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal2
{
    public partial class Equipamiento : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public CheckBoxList getEquipamiento()
        {
            return this.checkEquipamiento;
        }

        protected void validaCheck(object source, ServerValidateEventArgs args)
        {
            foreach (ListItem item in checkEquipamiento.Items)
            {
                if (item.Selected)
                {
                    args.IsValid = true;
                    break;
                }
                else
                {
                    args.IsValid = false;
                }

            }
        }
    }
}
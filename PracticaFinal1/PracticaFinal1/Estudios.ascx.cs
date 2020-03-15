using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal1
{
    public partial class Estudios : System.Web.UI.UserControl
    {
        public event EventHandler selecSecu;
        bool verificaSecu;

        public bool VerificaSecu { get => verificaSecu; set => verificaSecu = value; }

        public CheckBoxList getEstudios()
        {
            return this.estudioCheck;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void validaCheck(object source, ServerValidateEventArgs args)
        {
            foreach (ListItem item in estudioCheck.Items)
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

        public virtual void selecSecuIncompleto(object sender, EventArgs e)
        {



            this.selecSecu?.Invoke(sender, e);
            if (this.estudioCheck.SelectedValue == ("Secundario incompleto"))
                {
                    VerificaSecu = false;

                }
                else
                {
                    VerificaSecu = true;
                }
            this.selecSecu?.Invoke(sender, e);
        }
    }
}
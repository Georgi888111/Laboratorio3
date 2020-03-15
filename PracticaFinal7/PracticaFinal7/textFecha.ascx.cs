using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal7
{
    public partial class textFecha : System.Web.UI.UserControl
    {
        private bool validaCheckFecha;

        public bool ValidaCheckFecha { get => validaCheckFecha; set => validaCheckFecha = value; }

        public TextBox getFecha()
        {
            return this.fecha;
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fechaNoValida(object source, ServerValidateEventArgs args)
        {
           
            if (!String.IsNullOrEmpty(fecha.Text))
            {
                DateTime date = DateTime.Parse(fecha.Text);
                if (date > DateTime.Now)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            else
            {
                fecha.TextMode.Equals("");
                
            }
           
        }

        protected void fechaObligatoria(object source, ServerValidateEventArgs args)
        {
            if (validaCheckFecha == true)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal1
{
    public partial class MasterPageParcial : System.Web.UI.MasterPage
    {
        private Button guardarBtn;
        private Button sessionBtn;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.guardarBtn = ContentPlaceHolder2.FindControl("boton") as Button;
            this.sessionBtn = ContentPlaceHolder2.FindControl("botonSesion") as Button;

        }

        protected void GuardarMaster_Click(object sender, EventArgs e)
        {
            if (!guardarBtn.Visible)
            {
                guardarBtn.Visible = true;
                sessionBtn.Visible = false;
            }
           

        }

        protected void SessionMaster_Click(object sender, EventArgs e)
        {
            if (!sessionBtn.Visible)
            {
                sessionBtn.Visible = true;
                guardarBtn.Visible = false;
            }

        }
    }
}
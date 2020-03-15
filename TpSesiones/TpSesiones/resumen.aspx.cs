using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpSesiones
{
    public partial class resumen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            datos.Items.Add(new ListItem(Session["nombre"].ToString(), "nombre"));
            datos.Items.Add(new ListItem(Session["apellido"].ToString(), "apellido"));
            datos.Items.Add(new ListItem(Session["dni"].ToString(), "dni"));
            datos.Items.Add(new ListItem(Session["domicilio"].ToString(), "domicilio"));
            datos.Items.Add(new ListItem(Session["nacionalidad"].ToString(), "nacionalidad"));
            datos.Items.Add(new ListItem(Session["sexo"].ToString(), "sexo"));
            datos.Items.Add(new ListItem(Session["fechaNac"].ToString(), "fechaNac"));
            
            estudio.Items.Add(new ListItem(Session["nivel"].ToString(), "nivel"));
            estudio.Items.Add(new ListItem(Session["titulo"].ToString(), "titulo"));
            estudio.Items.Add(new ListItem(Session["establecimiento"].ToString(), "establecimiento"));

            trabajo.Items.Add(new ListItem(Session["periodo"].ToString(), "periodo"));
            trabajo.Items.Add(new ListItem(Session["lugar"].ToString(), "lugar"));
            trabajo.Items.Add(new ListItem(Session["tarea"].ToString(), "tarea"));

            idioma.Items.Add(new ListItem(Session["idioma"].ToString(), "idioma"));
            idioma.Items.Add(new ListItem(Session["nivel"].ToString(), "nivel"));
        }
    }
}
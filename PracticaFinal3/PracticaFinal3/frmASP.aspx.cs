using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal3
{
    public partial class frmASP : System.Web.UI.Page
    {
        private List<string> campos = new List<string>();
        private List<string> informacion = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void validaCheck(object source, ServerValidateEventArgs args)
        {
            bool combo = checkBloquea.Checked;
            if (combo)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void boton_Click(object sender, EventArgs e)
        {
            if (!validaciones.HasAttributes)
            {
                this.LlenarListas();
                DataTable resultados = new DataTable();
                resultados.Columns.Add(new DataColumn("Campo"));
                resultados.Columns.Add(new DataColumn("Informacion"));
                DataRow row;
                for (int i = 0; i < this.campos.Count; i++)
                {

                    row = resultados.NewRow();
                    row["Campo"] = this.campos[i];
                    row["Informacion"] = this.informacion[i];
                    resultados.Rows.Add(row);
                }
                this.tablaResultados.DataSource = resultados;
                this.tablaResultados.DataBind();
            }
        }

        private void LlenarListas()
        {
            campos.Add("Apellido");
            informacion.Add(this.apellido.getNombre().Text);
            campos.Add("Nombre");
            informacion.Add(this.nombre.getNombre().Text);
            campos.Add("Sexo");
            informacion.Add(this.radioSexo.SelectedValue);
            campos.Add("Nacionalidad");
            informacion.Add(this.Nacionalidad.getNacionalidad().SelectedValue);
            campos.Add("Bloqueado");
            informacion.Add("Esta bloqueado");
            campos.Add("Edad");
            informacion.Add(this.Edad.getEdad().Text);
            campos.Add("Antecedentes");
            informacion.Add(this.textAntecedente.Text);
           

        }

        protected void botonSesion_Click(object sender, EventArgs e)
        {
            if (!validaciones.HasAttributes)
            {
                Session["apellido"] = apellido.getNombre().Text;
                Session["nombre"] = nombre.getNombre().Text;
                Session["sexo"] = radioSexo.SelectedValue;
                Session["nacionalidad"] = Nacionalidad.getNacionalidad().SelectedValue;
                Session["bloqueado"] = "Esta bloqueado";
                Session["edad"] = Edad.getEdad().Text;
                Session["antecedentes"] = textAntecedente.Text;
                Response.Redirect("DatosSesionXML.aspx");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal1
{
    public partial class Empleado : System.Web.UI.Page
    {
        private List<string> campos = new List<string>();
        private List<string> informacion = new List<string>();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            boton.Visible = false;
            botonSesion.Visible = false;
          
            Estudios.selecSecu += new EventHandler(bloqueaDelegacion);

        }

        protected void boton_Click(object sender, EventArgs e)
        {
            if (!validacionLista.HasAttributes)
            {

                DataTable resultados = new DataTable();
                resultados.Columns.Add(new DataColumn("Campo"));
                resultados.Columns.Add(new DataColumn("Informacion"));
                this.LlenarListas();
                DataRow row;
                for (int i = 0; i < this.campos.Count; i++)
                {
                    row = resultados.NewRow();
                    row["Campo"] = this.campos[i];
                    row["Informacion"] = this.informacion[i];

                    resultados.Rows.Add(row);
                }
                this.GridView1.DataSource = resultados;
                this.GridView1.DataBind();
            }
        }


        private void LlenarListas()
        {
            campos.Add("Apellido");
            informacion.Add(this.apellido.Text);
            campos.Add("Nombre");
            informacion.Add(this.nombre.Text);
            campos.Add("DNI");
            informacion.Add(this.Dni.getDni().Text);
            campos.Add("Tipo de contrato");
            informacion.Add(this.TipoContrato.getContrato().SelectedValue);
            campos.Add("Régimen");
            informacion.Add(this.contrato.SelectedValue);
            campos.Add("Delegación");
            informacion.Add(this.Delegacion.getDelegacion().SelectedValue);
            campos.Add("Estudios");
            informacion.Add(this.Estudios.getEstudios().SelectedValue);
            campos.Add("Descripcion");
            informacion.Add(this.descripcion.Text);

        }

        protected void botonSesion_Click(object sender, EventArgs e)
        {
            if (!validacionLista.HasAttributes)
            {
                Session["apellido"] = apellido.Text;
                Session["nombre"] = nombre.Text;
                Session["dni"] = Dni.getDni().Text;
                Session["contrato"] = TipoContrato.getContrato().SelectedValue;
                Session["regimen"] = contrato.SelectedValue;
                Session["delegacion"] = Delegacion.getDelegacion().SelectedValue;
                Session["estudios"] = Estudios.getEstudios().SelectedValue;
                Session["descripcion"] = descripcion.Text;
                Response.Redirect("resultadoASP.aspx");
            }
        }

        public void bloqueaDelegacion(object sender, EventArgs e)
        {
           
            if (Estudios.VerificaSecu==true)
            {
                this.Delegacion.getDelegacion().Items.FindByValue("Sede central").Enabled=true;
                
            }
            else
            {
                this.Delegacion.getDelegacion().Items.FindByValue("Sede central").Enabled = false;
            }
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpCreaciónCU
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int contador=0;
           
            if (this.apellido.estaVacio())
            {
                labelApellido.Text = "El campo debe estar completo";
            }
            else
            {
                labelApellido.Text = "";
                contador++;
            }
            if (this.nombre.estaVacio())
            {
                labelNombre.Text = "El campo debe estar completo";
            }
            else
            {
                labelNombre.Text = "";
                contador++;
            }
            if (!this.cuit.ValidateCuit())
            {
                labelCuit.Text = "Verifique que su cuit este correcto";
            }
            else
            {
                labelCuit.Text = "";
                contador++;
            }
                if (!this.edad.esMayor())
            {
                labelEdad.Text = "Verifique haber llenado el campo o ser mayor de edad, se solicita un mayor para este trámite";
            }
            else
            {
                labelEdad.Text = "";
                contador++;
            }
            
            
                if (this.hijos.validaHijos())
                {
                    labelHijos.Text = "Verifique la cantidad de hijos, debe tener uno como mínimo 1 y 17 como máximo";
            }
            else
            {
                labelHijos.Text = "";
                contador++;
            }
            if (contador == 5) 
            {
                    Response.Redirect("Finalizacion.aspx");
                }
            }
            
          
         
            
        }
    }

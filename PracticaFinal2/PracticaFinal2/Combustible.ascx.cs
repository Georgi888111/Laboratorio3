using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal2
{
    
    public partial class Combustible : System.Web.UI.UserControl
    {
        public event EventHandler equipBloqueado;
        private bool estaSelec = false;

        public bool EstaSelec { get => estaSelec; set => estaSelec = value; }

        public DropDownList getCombustible()
        {
            return this.combus;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected virtual void OnEquipoBloqueado(object sender, EventArgs e)
        //{
        //    if (this.equipBloqueado != null)
        //    {
        //        this.equipBloqueado(sender, e);
        //    }
        //}

        protected void bloqueaEquipamientos(object sender, EventArgs e)
        {
           
            if (this.combus.SelectedValue == "Diesel")
            {
                EstaSelec = true;
            }
            else
            {
                EstaSelec = false;
            }

            this.equipBloqueado?.Invoke(sender, e);
        }
    }
    }

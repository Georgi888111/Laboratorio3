using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpCreaciónCU
{
   

    public partial class TextBoxNoEmpty : System.Web.UI.UserControl
    {
        public event EventHandler NoText;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public virtual void OnClick(object sender)
        {
            if (NoText != null)
            {
                this.NoText(sender, new EventArgs());
            }
        }


        public bool estaVacio()
            {
                if (String.IsNullOrEmpty(this.TextBox1.Text))
                {
                    return true;
                }
                return false;
            }
        }
    }

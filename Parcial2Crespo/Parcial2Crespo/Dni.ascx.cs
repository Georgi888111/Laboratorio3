﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Crespo
{
    public partial class Dni : System.Web.UI.UserControl
    {
        private TextBox dniTxt = new TextBox();

        public TextBox DniTxt { get => dniTxt; set => dniTxt = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
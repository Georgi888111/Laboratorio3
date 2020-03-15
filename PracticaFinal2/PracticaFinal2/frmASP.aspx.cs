using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal2
{
    public partial class frmASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Combustible.equipBloqueado += (Combustible_equipBloqueado);
            if (radioUso.Items.FindByValue("Nuevo").Selected)
            {
                this.Combustible.getCombustible().Items.FindByValue("GNC").Enabled = false;

            }
            else
            {
                this.Combustible.getCombustible().Items.FindByValue("GNC").Enabled = true;
            }

        }

        protected void btnGuarda_Click(object sender, EventArgs e)
        {
            if (!validaLista.HasAttributes)
            {
                int filas = 8;
                int celdas = 2;
                for (int j = 0; j < filas; j++)
                {
                    TableRow r = new TableRow();
                    for (int i = 0; i < celdas; i++)
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("Tipo vehiculo "
                    + j.ToString() + ", cell " + i.ToString()));
                        r.Cells.Add(c);


                    }

                    tabla.Rows.Add(r);
                }

            }

        }

        protected void Combustible_equipBloqueado(object sender, EventArgs e)
        {
            if (Combustible.EstaSelec == true)
            {

                Equipamiento1.getEquipamiento().Items.FindByValue("Alarma").Enabled = false;
                //foreach(ListItem item in Equipamiento1.getEquipamiento().Items)
                // {
                //     if (item.Value == "Alarma")
                //     {
                //         item.Enabled = true;
                //     }
            }
            else
            {
                Equipamiento1.getEquipamiento().Items.FindByValue("Alarma").Enabled = true;
            }
        }
    }
}

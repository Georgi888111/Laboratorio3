using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.clases
{
    public class Cliente
    {

        private String id, compania, contacto, titulo, direccion, ciudad, region, codpostal, pais, telefono, fax;

        public String Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String Codpostal
        {
            get { return codpostal; }
            set { codpostal = value; }
        }

        public String Region
        {
            get { return region; }
            set { region = value; }
        }

        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public String Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        public String Compania
        {
            get { return compania; }
            set { compania = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}

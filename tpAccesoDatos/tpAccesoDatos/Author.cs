using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpAccesoDatos
{
    class Author
    {
        private String id;
        private String apellido;
        private String nombre;
        private String telefono;
        private String direccion;
        private String ciudad;
        private String estado;
        private String codPostal;
        private Boolean contrato;



       
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
      
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }
     
        public bool Contrato { get => contrato; set => contrato = value; }
        public string Id { get => id; set => id = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CodPostal { get => codPostal; set => codPostal = value; }
    }
}

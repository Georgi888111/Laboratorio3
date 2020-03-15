using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Web.Script.Serialization;

namespace PracticaFinal5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // llenarJson();
            //leerJson();
            cargarYMuestraArray();

        }

        public static void llenarJson()
        {
            string outputJSON ="";
            Conexion conexion = new Conexion();
           
            List<Factura> facturas = new List<Factura>(); 
            facturas=conexion.llenaFacturas();
            List<Articulo> articulos = new List<Articulo>();
            articulos = conexion.llenaArticulos();
         
            
                outputJSON = JsonConvert.SerializeObject(facturas, Formatting.Indented);
           
            File.WriteAllText("MiSegundoJSON.json", outputJSON);

        }

        public static void leerJson()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string outputJSON = File.ReadAllText("MiSegundoJSON.json");
            List<Factura> facturas = ser.Deserialize<List<Factura>>(outputJSON);
            foreach(Factura fac in facturas)
            {
                Console.WriteLine("Id: " + fac.Id.ToString());
                Console.WriteLine("Fecha: " + fac.Fecha.ToString());
                Console.WriteLine("Total: " + fac.Total.ToString());
            }
            
            Console.ReadLine();
        }

        public static void cargarYMuestraArray()
        {
            
            int[] numeros = {1,2,3,4,5,6,7};
            IEnumerable<int> valores = from n in numeros where n % 2 == 0 select n;
            foreach(int num in valores)
            {
                Console.WriteLine(num);
            }

        }
    }
}

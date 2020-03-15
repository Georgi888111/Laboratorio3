using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PracticaXml
{
    class Program
    {
        static void Main(string[] args)
        {
            escribirXml();
            leerXml();
            
        }
        public static void escribirXml()
        {
            XmlTextWriter writer;
            writer = new XmlTextWriter("C:\\Users\\Georgi\\source\\repos\\PracticaXml\\primerXml.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Futbolistas");
            writer.WriteStartElement("Jugador");
            writer.WriteAttributeString("Pais","Uruguay");
            writer.WriteElementString("Nombre", "Franco Garcia");
            writer.WriteElementString("Equipo", "Valencia C.F");
            writer.WriteEndElement();
            writer.WriteStartElement("Jugador");
            writer.WriteAttributeString("Pais", "Argentina");
            writer.WriteElementString("Nombre", "Lionel Messi");
            writer.WriteElementString("Equipo", "Barcelona C.F");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();



        }

        public static void leerXml()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:\\Users\\Georgi\\source\\repos\\PracticaXml\\primerXml.xml");
            XmlNodeList futbolistas = xDoc.GetElementsByTagName("Futbolistas");
            XmlNodeList jugador =((XmlElement)futbolistas[0]).GetElementsByTagName("Jugador");
            foreach (XmlElement juga in jugador)
            {
                int i = 0;
                String nodoPais = juga.GetAttribute("Pais");
                XmlNodeList nodoNombre = juga.GetElementsByTagName("Nombre");
                XmlNodeList nodoEquipo = juga.GetElementsByTagName("Equipo");
                Console.WriteLine("Pais: "
                    + nodoPais);
                Console.WriteLine("Nombre: "
                    + nodoNombre[i].InnerText);
                Console.WriteLine("Equipo: "
                    + nodoEquipo[i].InnerText);

            }
        }
    }
}

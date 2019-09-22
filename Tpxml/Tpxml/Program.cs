using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Tpxml
{
    class Program
    {
        static void Main(string[] args)
        {
            String ruta = @"C:\Users\Georgi\miXML2.xml";
            //CrearDocumentoXML();
            //crearXML(ruta);
            leerXml(ruta);
            


        }

        public static void CrearDocumentoXML()
        {
            XDocument miXML = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("Lista de Empleados"),
            new XElement("Listado",
            new XElement("Empleados",
            new XElement("Empleado",
            new XAttribute("id", 4884),
            new XAttribute("nombreCompleto", "Rodriguez, Victor"),
            new XAttribute("cuil", 20103180326),
            new XElement("Sector",
            new XAttribute("denominacion", "Gerencia Recursos Humanos"),
            new XAttribute("id", "137"),
            new XAttribute("valorSemaforo", "130.13"),
            new XAttribute("colorSemaforo", "Verde")),
            new XAttribute("cupoAsignado", 1837.15),
            new XAttribute("cupoConsumido", 658.02)),


            new XElement("Empleado",
            new XAttribute("id", 1225),
            new XAttribute("nombreCompleto", "Sanchez, Juan Ignacio"),
            new XAttribute("cuil", 20271265817),
            new XElement("Sector",
            new XAttribute("denominacion", "Gerencia Operativa"),
            new XAttribute("id", "44"),
            new XAttribute("valorSemaforo", "130.13"),
            new XAttribute("colorSemaforo", "Rojo")),
            new XAttribute("cupoAsignado", 750.87),
            new XAttribute("cupoConsumido", 625.46))),
            new XElement("Subsectores", 5),
            new XElement("totalCupoAsignadoSubsector", 4217,21),
            new XElement("totalCupoConsumidoSector", 1405.88),
            new XElement("valorDial", 33.34)
            ));

            miXML.Save(@"C:\Users\Georgi\miXML.xml");
        }

        public static void crearXML(String file_path)
        {
            XmlTextWriter writer;
            writer = new XmlTextWriter(file_path, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();

            writer.WriteStartElement("Empleados");

            writer.WriteStartElement("Listado");

            writer.WriteStartElement("Empleado");
            writer.WriteAttributeString("id", "4884");
            writer.WriteAttributeString("nombreCompleto", "Rodriguez, Victor");
            writer.WriteAttributeString("cuil", "20103180326");

            writer.WriteStartElement("sector");
            writer.WriteAttributeString("denominacion", "Gerencia Recursos Humanos");
            writer.WriteAttributeString("id", "137");
            writer.WriteAttributeString("valorSemaforo=", "130.13");
            writer.WriteAttributeString("colorSemaforo", "VERDE");
            writer.WriteEndElement();

            writer.WriteElementString("cupoAsignado", "1837.15");
            writer.WriteElementString("cupoConsumido", "658.02");

            writer.WriteEndElement();


            writer.WriteStartElement("Empleado");
            writer.WriteAttributeString("id", "1225");
            writer.WriteAttributeString("nombreCompleto", "Sanchez, Juan Ignacio");
            writer.WriteAttributeString("cuil", "20271265817");

            writer.WriteStartElement("sector");
            writer.WriteAttributeString("denominacion", "Gerencia Operativa");
            writer.WriteAttributeString("id", "44");
            writer.WriteAttributeString("valorSemaforo=", "130.13");
            writer.WriteAttributeString("colorSemaforo", "ROJO");
            writer.WriteEndElement();

            writer.WriteElementString("cupoAsignado", "750.87");
            writer.WriteElementString("cupoConsumido", "625.46");

            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteElementString("subsectores", "5");
            writer.WriteElementString("totalCupoAsignadoSector", "4217.21");
            writer.WriteElementString("totalCupoConsumidoSector", "1405.88");
            writer.WriteElementString("valorDial", "33.34");

            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }

        public static void leerXml(String file_path)
        {

            XmlDocument xDoc= new XmlDocument();
            xDoc.Load(@"C:\Users\Georgi\miXML2.xml");
            XmlNodeList empleados = xDoc.GetElementsByTagName("Empleados");
            XmlNodeList lista = ((XmlElement)empleados[0]).GetElementsByTagName("Empleado");
            foreach (XmlElement nodo in lista)
            {
                int i = 0;
                XmlNodeList nId = nodo.GetElementsByTagName("id");
                XmlNodeList nNombreCompleto = nodo.GetElementsByTagName("nombreCompleto");
                XmlNodeList nCuil = nodo.GetElementsByTagName("cuil");

                if (nodo.HasChildNodes)
                {
                    XmlNodeList nIdSector = nodo.GetElementsByTagName("id");
                    XmlNodeList nColor = nodo.GetElementsByTagName("colorSemaforo");
                    XmlNodeList nValorS = nodo.GetElementsByTagName("valorSemaforo");
                    XmlNodeList nDenomi = nodo.GetElementsByTagName("denominacion");
                    Console.WriteLine("Elemento empleado {0} {1}", nId[i].InnerText, nNombreCompleto[i].InnerText, nCuil[i].InnerText);
                }
            }
        }
    } }

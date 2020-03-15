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
           // leerXml();
            leerReader();



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
            new XElement("sector",
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
            new XElement("sector",
            new XAttribute("denominacion", "Gerencia Operativa"),
            new XAttribute("id", "44"),
            new XAttribute("valorSemaforo", "130.13"),
            new XAttribute("colorSemaforo", "Rojo")),
            new XAttribute("cupoAsignado", 750.87),
            new XAttribute("cupoConsumido", 625.46))),
            new XElement("subsectores", 5),
            new XElement("totalCupoAsignadoSubsector", 4217.21),
            new XElement("totalCupoConsumidoSubsector", 1405.88),
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
            writer.WriteAttributeString("nombreCompleto", "Rodriguez,Victor");
            writer.WriteAttributeString("cuil", "20103180326");

            writer.WriteStartElement("sector");
            writer.WriteAttributeString("denominacion", "Gerencia Recursos Humanos");
            writer.WriteAttributeString("id", "137");
            writer.WriteAttributeString("valorSemaforo", "130.13");
            writer.WriteAttributeString("colorSemaforo", "VERDE");
            writer.WriteEndElement();

            writer.WriteElementString("cupoAsignado", "1837.15");
            writer.WriteElementString("cupoConsumido", "658.02");

            writer.WriteEndElement();


            writer.WriteStartElement("Empleado");
            writer.WriteAttributeString("id", "1225");
            writer.WriteAttributeString("nombreCompleto", "Sanchez,Juan Ignacio");
            writer.WriteAttributeString("cuil", "20271265817");

            writer.WriteStartElement("sector");
            writer.WriteAttributeString("denominacion", "Gerencia Operativa");
            writer.WriteAttributeString("id", "44");
            writer.WriteAttributeString("valorSemaforo", "130.13");
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

        public static void leerXml()
        {

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\Georgi\miXML.xml");

            XmlNodeList empleados = xDoc.GetElementsByTagName("Empleados");


            foreach (XmlElement item in empleados)
            {
                XmlNodeList listado = xDoc.GetElementsByTagName("Listado");
                foreach (XmlElement itemHijo in listado)
                {

                    XmlNodeList empleadosHijo = itemHijo.GetElementsByTagName("Empleado");
                    foreach (XmlElement nodo in empleadosHijo)
                    {


                        String idEmpleado = nodo.GetAttribute("id");
                        String nombreCompleto = nodo.GetAttribute("nombreCompleto");
                        String cuil = nodo.GetAttribute("cuil");
                        Console.WriteLine("id: " + idEmpleado + " Nombre Completo: " + nombreCompleto + " Cuil: " + cuil);


                        XmlNode sectores = nodo["sector"];

                        String denominacion = sectores.Attributes["denominacion"].Value;
                        String idSector = sectores.Attributes["id"].Value;
                        String valSemaforo = sectores.Attributes["valorSemaforo"].Value;
                        String colorSemaforo = sectores.Attributes["colorSemaforo"].Value;


                        Console.WriteLine("Info Sector:");
                        Console.WriteLine("Denominación: " + denominacion + " ID: " + idSector + " Valor Semáforo: " + valSemaforo + " Color Semáforo: " + colorSemaforo);
                        String cupoAsig = nodo.GetAttribute("cupoAsignado");
                        String cupoConsu = nodo.GetAttribute("cupoConsumido");
                        Console.WriteLine("Cupo asignado: " + cupoAsig + " Cupo consumido: " + cupoConsu);
                    }


                }

                XmlNodeList subsec = xDoc.GetElementsByTagName("subsectores");
                Console.WriteLine("Cantidad Subsectores: " + subsec[0].InnerText);
                XmlNodeList cupo = xDoc.GetElementsByTagName("totalCupoAsignadoSubsector");
                Console.WriteLine("Total Cupo Asignado Sector: " + cupo[0].InnerText);
                XmlNodeList cupoCon = xDoc.GetElementsByTagName("totalCupoConsumidoSubsector");
                Console.WriteLine("Total Cupo Consumido Sector: " + cupoCon[0].InnerText);
                XmlNodeList valor = xDoc.GetElementsByTagName("valorDial");
                Console.WriteLine("Valor Dial: " + valor[0].InnerText);

            }

        }

        public static void leerReader()
        {
            using (XmlReader reader = XmlReader.Create(@"C:\Users\Georgi\miXML2.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "Empleados":

                                Console.WriteLine("Start <Empleados> element.");
                                break;

                            case "Listado":

                                Console.WriteLine("Start <Listado> element.");
                                break;

                            case "Empleado":
                                Console.WriteLine("Start <Empleado> element.");
                                string id = reader["id"];
                                string nombre = reader["nombreCompleto"];
                                string cuil = reader["cuil"];

                              
                                if (id != null && nombre != null && cuil != null)
                                {
                                    Console.WriteLine("Empleado");
                                    Console.WriteLine("ID: " +
                                    id);
                                    Console.WriteLine("Nombre completo: " +
                                    nombre);
                                    Console.WriteLine("Cuil: " +
                                    cuil);
                                   
                                }

                                break;


                                    case "sector":

                                        Console.WriteLine("Start <sector> element.");
                                        string denomi = reader["denominacion"];
                                        string idS = reader["id"];
                                        string valorSemaforo = reader["valorSemaforo"];
                                        string colorSemaforo = reader["colorSemaforo"];

                                        if (idS != null && denomi != null && valorSemaforo != null && colorSemaforo != null)
                                        {
                                            Console.WriteLine("Sector");
                                            Console.WriteLine("Denominacion: " +
                                            denomi);
                                            Console.WriteLine("Id: " +
                                            idS);
                                            Console.WriteLine("Valor semaforo: " +
                                            valorSemaforo);
                                            Console.WriteLine("Color semaforo: " +
                                            colorSemaforo);

                                        }

                                        break;

                            case "cupoAsignado":
                                        Console.WriteLine("Start <cupoAsignado> element.");
                                        string cupoAsig = reader.ReadInnerXml();
                                if (cupoAsig != null)
                                {
                                    Console.WriteLine("Cupo asignado: " + cupoAsig);
                                }
                                        break;
                            case "cupoConsumido":
                                Console.WriteLine("Start <cupoConsummido> element.");
                                string cupoConsum= reader.ReadInnerXml();

                                if (cupoConsum != null)
                                {
                                    Console.WriteLine("Cupo asignado: " + cupoConsum);
                                }
                                break;
                            case "subsectores":
                                Console.WriteLine("Start <subsectores> element.");
                                string subsectores = reader.ReadInnerXml();
                                if (subsectores != null)
                                {
                                    Console.WriteLine("Cantidad subsectores: " + subsectores);
                                }
                                break;
                            case "totalCupoAsignadoSector":
                                Console.WriteLine("Start <totalCupoAsignadoSector> element.");
                                string totalAsig = reader.ReadInnerXml();
                                if (totalAsig != null)
                                {
                                    Console.WriteLine("Cantidad subsectores: " + totalAsig);
                                }
                                break;
                            case "totalCupoConsumidoSector":
                                Console.WriteLine("Start <totalCupoConsumidoSector> element.");
                                string totalCons = reader.ReadInnerXml();
                                if (totalCons != null)
                                {
                                    Console.WriteLine("Cantidad subsectores: " + totalCons);
                                }

                                break;

                            case "valorDial":
                                Console.WriteLine("Start <valorDial> element.");
                                string valorDial = reader.ReadInnerXml();
                                if (valorDial != null)
                                {
                                    Console.WriteLine("Cantidad subsectores: " + valorDial);
                                }
                                break;

                        }
                    }

                }
            }

        }
    }
}
        
     

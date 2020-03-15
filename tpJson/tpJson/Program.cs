using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace tpJson
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //leerJson();
            leerBaseDatos();
           

        }

        public static void leerJson()
        {
            string json =
                @"{'name': 'Argentina',
                'alpha2Code': 'AR',
                'alpha3Code': 'ARG',
                'capital': 'Buenos Aires',
                'altSpellings': ['AR', 'Argentine Republic', 'República Argentina'],
                'region': 'Americas',
                'subregion': 'South America',
                'population': 43590400,
                'latlng': [-34.0, -64.0],
                'area': 2780400.0,
                'gini': 44.5,
                'timezones': ['UTC-03:00'],
                'borders': ['BOL', 'BRA', 'CHL', 'PRY', 'URY'],
                'nativeName': 'Argentina',
                'numericCode': '032',
                'currencies': [{
                'code': 'ARS',
                'name': 'Argentine peso',
                'symbol': '$'
                 }],

                'languages': [{
                'iso639_1': 'es',
                'iso639_2': 'spa',
                'name': 'Spanish',
                'nativeName': 'Español'
                 }],

                'translations': {
                'de': 'Argentinien',
                'es': 'Argentina',
                'fr': 'Argentine',
                'ja': 'アルゼンチン',
                'it': 'Argentina',
                'br': 'Argentina',
                'pt': 'Argentina',
                'nl': 'Argentinië',
                'hr': 'Argentina'
              
                
               }";





            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }
        }


            public static MySqlConnection connection()
            {

                MySqlConnection conect = new MySqlConnection();
                string cadenaCon = "Server=localhost;Port=3306;Database=tpjson;Uid=root;Pwd=;";

                try
                {
                    conect.ConnectionString = cadenaCon;
                    conect.Open();
                    Console.WriteLine("La base se ha conectado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("La base no se ha conectado");
                }

                return conect;



            }
        public static void leerBaseDatos()


        {
            

            String select = "select * from escritor";

            MySqlCommand cmd = new MySqlCommand(select, connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            List<JObject> escritoresLibros = new List<JObject>();

            while (reader.Read())
            {

            JObject escritorLibro = new JObject(
            new JProperty("id", reader.GetString(0)),
            new JProperty("apellido", reader.GetString(1)),
            new JProperty("nombre", reader.GetString(2)),
            new JProperty("dni", reader.GetString(3))
           
            
        );
                escritoresLibros.Add(escritorLibro);






            }


            reader.Close();

            String selectLibro = "select * from libro";

            MySqlCommand cmd2 = new MySqlCommand(selectLibro, connection());
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            List<JObject> libros = new List<JObject>();

            while (reader2.Read())
            {

                JObject libro = new JObject(
                new JProperty("nombre", reader2.GetString(0)),
                new JProperty("año", reader2.GetString(1)),
                new JProperty("editorial", reader2.GetString(2)),
                new JProperty("idEscritor", reader2.GetString(3))


            );
                libros.Add(libro);






            }



            reader2.Close();

            using (StreamWriter file = File.CreateText(@"C:\Users\Georgi\source\repos\escritorLibros.txt"))
            {
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.Formatting = Formatting.Indented;
                   
                    foreach (JObject escritor in escritoresLibros)
                    {


                        escritor.WriteTo(writer);
                        writer.WriteStartArray();
                        

                        foreach (JObject libro in libros)
                        {
                           
                           
                            if (escritor.GetValue("id").Equals(libro.GetValue("idEscritor")))
                            {
                              
                               
                              
                              
                                libro.WriteTo(writer);
                               
                              


                            }

                           

                         


                        }

                        writer.WriteEndArray();
                    }
                   
                }

            }
        }
    }
}

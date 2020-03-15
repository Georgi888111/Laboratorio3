using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TpWebServices
{
    /// <summary>
    /// Descripción breve de Convert
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Convert : System.Web.Services.WebService
    {

        private double ConvertToMeters(double input, String inputUnit)
        {

            if (inputUnit.Equals("km"))
            {
                return input * 1000;
            }
            else if (inputUnit.Equals("dm"))
            {
                return input / 10;
            }
            else if (inputUnit.Equals("cm"))
            {
                return input / 100;
            }
            else if (inputUnit.Equals("mm"))
            {
                return input / 1000;
            }
            else if (inputUnit.Equals("µm"))
            {
                return input / 1000000;
            }
            else
            {
                return input;
            }

        }

        private double ConvertIntoUnit(double input, String inputUnit, String outputUnit)
        {

            switch (outputUnit)
            {
                case "km":
                    return ConvertToMeters(input, inputUnit) / 1000;

                case "dm":
                    return ConvertToMeters(input, inputUnit) * 10;

                case "cm":
                    return ConvertToMeters(input, inputUnit) * 100;

                case "mm":
                    return ConvertToMeters(input, inputUnit) * 1000;

                case "µm":
                    return ConvertToMeters(input, inputUnit) * 1000000;

                case "m":
                    return ConvertToMeters(input, inputUnit);
                default:
                    return -1;
            }

        }

        [WebMethod]
        public String GetConversion(double input, String inputUnit, String outputUnit)
        {
            return ConvertIntoUnit(input, inputUnit, outputUnit).ToString();
        }
    }

}


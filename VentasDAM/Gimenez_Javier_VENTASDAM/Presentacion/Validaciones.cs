using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// Clase con los métodos utilizados para validar diferentes campos
    /// </summary>
    public class Validaciones
    {
        /// <summary>
        /// Función para validar un campo de texto, dependiendo de su longitud máxima y si permite valor nulo
        /// </summary>
        /// <param name="cadena">cadena de texto a validar</param>
        /// <param name="longitudMaxima">longitud máxima permitida para la cadena de texto</param>
        /// <param name="permiteNulo">indica si se permite valor nulo o no</param>
        /// <returns></returns>
        public static int ValidarCadena(string cadena, int longitudMaxima, bool permiteNulo)
        {
            int codigoError = 0;
            cadena = cadena.Trim(); // no permito que la cadena tenga solo espacios

            if (cadena.Length > longitudMaxima) 
                codigoError = 1;
            else if (cadena.Length < 1 && !permiteNulo) 
                codigoError = 2;

            return codigoError;
        }

        public static int ValidarURL(string cadena, int longitudMaxima, bool permiteNulo)
        {
            int codigoError = ValidarCadena(cadena, 255, permiteNulo);
            if (codigoError == 0) 
            {
                cadena = cadena.Trim().ToLower();
                string patronHttp = "^http://(www.)?([a-z0-9](-?/?[a-z0-9])*.[a-z]{2,3})+$";
                string patronHttps = "^https://(www.)?(([a-z0-9]+.){2,}.[a-z]{2,3}.[a-z]{2,3})(/([a-z0-9-]+/?))*$";
                if (cadena.Length > 0 && (!Regex.IsMatch(cadena, patronHttp) && !Regex.IsMatch(cadena, patronHttps)))
                {
                    codigoError = 3;
                }
            }

            return codigoError;
        }

        public static int ValidarTelefono(string cadena, int longitudMinima)
        {
            int codigoError = 0;
            cadena = cadena.Trim();

            if (cadena.Length > 0 && cadena.Length < longitudMinima)
                codigoError = 1;           

            return codigoError;
        }

        public static int ValidarFechaNacimiento(DateTimePicker fechaNacimiento)
        {
            int codigoError = 0;
            DateTimePicker fechaNacientoMax = new DateTimePicker(); 
            fechaNacientoMax.MaxDate = DateTime.Today;

            if (fechaNacimiento.Value >= fechaNacientoMax.Value)
                codigoError = 1;

            return codigoError;
        }
        
    }
}

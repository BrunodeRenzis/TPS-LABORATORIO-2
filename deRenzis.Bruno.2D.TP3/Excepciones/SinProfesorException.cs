using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SinProfesorException():base("No hay profesor disponible")
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public SinProfesorException(string mensaje):base(mensaje)
        {

        }
    }
}

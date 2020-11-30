using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException: Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NacionalidadInvalidaException():base()
        {

        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public NacionalidadInvalidaException(string message):base(message)
        {

        }
    }
}

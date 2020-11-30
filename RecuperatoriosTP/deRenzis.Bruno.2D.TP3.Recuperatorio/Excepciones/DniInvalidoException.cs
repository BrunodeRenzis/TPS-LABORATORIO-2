using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DniInvalidoException():base()
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public DniInvalidoException(Exception e): base("Dni inválido",e)
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public DniInvalidoException(string message)
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public DniInvalidoException(string message, Exception e)
        {

        }
    }
}

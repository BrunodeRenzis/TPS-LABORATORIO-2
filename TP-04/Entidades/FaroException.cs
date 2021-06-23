using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FaroException : Exception
    {
        /// <summary>
        /// Constructor por defecto de una excepciíon faro
        /// </summary>
        public FaroException()
        {
        }

        /// <summary>
        /// Constructor con mensaje de una excepción faro
        /// </summary>
        /// <param name="message"></param>
        public FaroException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor con mensaje e innerException faro
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public FaroException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

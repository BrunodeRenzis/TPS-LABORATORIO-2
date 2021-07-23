using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FaroRepetidoException : Exception
    {
        /// <summary>
        /// Constructor por defecto de una excepciíon faro repetido
        /// </summary>
        public FaroRepetidoException()
        {
        }

        /// <summary>
        /// Constructor con mensaje de una excepción faro repetido
        /// </summary>
        /// <param name="message"></param>
        public FaroRepetidoException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor con mensaje e innerException faro repetido
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public FaroRepetidoException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}

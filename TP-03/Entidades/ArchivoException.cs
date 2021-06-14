using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoException : Exception
    {
        /// <summary>
        /// Constructor por defecto de una excepciíon Archivo
        /// </summary>
        public ArchivoException()
        {
        }


        /// <summary>
        /// Constructor con mensaje de una excepción Archivo
        /// </summary>
        /// <param name="message"></param>
        public ArchivoException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor con mensaje e innerException Archivo
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException:Exception
    {
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException):base("Error en el archivo",innerException)
        {
            
        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public ArchivosException() : base("Error en el archivo")
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public ArchivosException(string mensaje) : base(mensaje)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Excepciones
{
    public class ArchivoException : Exception
    {
        public ArchivoException(Exception innerException) : base("Error en el archivo", innerException)
        {

        }

        public ArchivoException() : base("Error en el archivo")
        {

        }

        public ArchivoException(string mensaje,Exception ex) : base(mensaje,ex)
        {

        }

    }
}
